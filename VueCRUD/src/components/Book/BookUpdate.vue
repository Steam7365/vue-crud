<template>
    <el-form :model="store.state.BookInfo" label-width="120px" id="addform">
        <h3>修改数据</h3>

        <el-form-item label="编号：">
            <el-input v-model="store.state.BookInfo.id" disabled />
        </el-form-item>

        <el-row>
            <el-col :span="12">
                <el-form-item label="书名：">
                    <el-input v-model="store.state.BookInfo.name" />
                </el-form-item>
            </el-col>
            <el-col :span="12">

                <el-form-item label="发布时间：">
                    <el-date-picker v-model="store.state.BookInfo.createdDate" type="date" placeholder="选择时间"
                        style="width: 100%" />
                </el-form-item>
            </el-col>
        </el-row>

        <el-row>
            <el-col :span="12">
                <el-form-item label="作者：">
                    <el-input v-model="store.state.BookInfo.author" />
                </el-form-item>
            </el-col>

            <el-col :span="12">
                <el-form-item label="书本类型">
                    <el-select v-model="store.state.BookInfo.bookTypeId" placeholder="请选择书本类型">
                        <el-option :label="item.typeName" :value="item.id" v-for="item in store.state.BookTypes"
                            :key="item.id" />
                    </el-select>
                </el-form-item>
            </el-col>
        </el-row>
        <el-form-item>
            <el-button type="primary" @click="onSubmit">保存</el-button>
        </el-form-item>
    </el-form>
</template>

<script lang="ts" setup>
import axios from 'axios'
import store from '../../store'
import { Store } from 'vuex';

const onSubmit = () => {
    store.state.BookInfo.booktypeId = store.state.BookInfo.bookTypeId;
    console.log(JSON.stringify(store.state.BookInfo));
    axios({
        url: "https://localhost:7159/api/Book/PutUpdateBook",
        method: "Put",
        data: JSON.stringify(store.state.BookInfo),
        headers: {
            'Content-Type': "application/json"
        },
    }).then(function (resp) {
        store.state.BookInfos.splice(store.state.Bookindex, 1, resp.data);
        console.log(store.state.BookInfos);
    })
}
</script>

<style>
#addform>h3 {
    text-align: center;
}
</style>