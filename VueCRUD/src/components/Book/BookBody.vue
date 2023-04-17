<template>
    <el-row>
        <el-col :span="12" id="leftBook">
            <el-table :data="bookinfo" style="width: 100%">
                <el-table-column fixed prop="id" label="id" width="150" />
                <el-table-column prop="name" label="name" width="120" />
                <el-table-column prop="createdDate" label="createdDate" width="270" />
                <el-table-column prop="author" label="author" width="120" />
                <el-table-column fixed="right" label="Operations" width="120">
                    <template #default="scope">
                        <el-button link type="primary" size="small"
                            @click="deleteBookClick(scope.$index, scope.row)">删除</el-button>
                        <el-button link type="primary" size="small"
                            @click="updateBookClick(scope.$index, scope.row)">修改</el-button>
                    </template>
                </el-table-column>
            </el-table>
            <el-col :span="24" class="colCreate">
                <el-button type="info" @click="AddBookClick" class="bcreate">添加</el-button>
            </el-col>
        </el-col>
        <el-col :span="11" id="rightBook">
            <transition name="bounce">
                <BookAdd v-if="isAdd"></BookAdd>
                <BookUpdate v-else></BookUpdate>
            </transition>

        </el-col>
    </el-row>
</template>

<script setup lang="ts">
import axios from 'axios'
import store from '../../store'
import { ref } from 'vue'
import { id } from 'element-plus/es/locale';
import BookUpdate from './BookUpdate.vue';
import BookAdd from './BookAdd.vue';

//判断是否是添加数据
const isAdd = ref(true);

//用于存储book中的全部信息
const bookinfo = ref(null);

//加载全部数据到表格
function getbook() {
    axios({
        url: "https://localhost:7159/api/Book/GetBooks",
        method: "get"
    }).then(function (resp) {
        store.state.BookInfos = resp.data;
        bookinfo.value = store.state.BookInfos;
    })
}
getbook();

//删除数据
const deleteBookClick = (index: number, row) => {
    console.log(row.id);
    axios({
        url: "https://localhost:7159/api/Book/DeleteByIdBooks",
        method: "Delete",
        params: { id: row.id },
    }).then(function (resp) {
        console.log(resp.status);
        bookinfo.value.splice(index, 1);
    })
}

//修改数据
const updateBookClick = (index: number, row) => {
    store.state.BookInfo = Object.assign({}, row);
    store.state.Bookindex = index;
    isAdd.value = false;
}
//添加数据
const AddBookClick = () => {
    isAdd.value = true;
}
</script>

<style>
.bcreate {
    margin-top: 20px;
    width: 80%;
}

.colCreate {
    text-align: center;
}

#leftBook {
    border: 2px solid #e2e2e2;
    padding: 20px;
}

#rightBook {
    margin-left: 20px;
    border: 2px solid #e2e2e2;
    padding: 20px;
}

/* 定义CSS过渡效果 */
.bounce-enter-active {
    animation: bounce-in 0.5s;
}

@keyframes bounce-in {
    0% {
        transform: scale(0);
    }

    50% {
        transform: scale(1.25);
    }

    100% {
        transform: scale(1);
    }
}
</style>
