<template>
    <el-form :model="form" label-width="120px" id="addform">
        <h3>添加数据</h3>

        <el-form-item label="编号：">
            <el-input v-model="form.id" disabled />
        </el-form-item>

        <el-row>
            <el-col :span="12">
                <el-form-item label="书名：">
                    <el-input v-model="form.name" />
                </el-form-item>
            </el-col>
            <el-col :span="12">

                <el-form-item label="发布时间：">
                    <el-date-picker v-model="form.createdDate" type="date" placeholder="选择时间" style="width: 100%" />
                </el-form-item>
            </el-col>
        </el-row>

        <el-row>
            <el-col :span="12">
                <el-form-item label="作者：">
                    <el-input v-model="form.author" />
                </el-form-item>
            </el-col>

            <el-col :span="12">
                <el-form-item label="书本类型">
                    <el-select v-model="typeName" placeholder="请选择书本类型">
                        <el-option :label="item.typeName" :value="item.id" v-for="item in store.state.BookTypes"
                            :key="item.id" />
                    </el-select>
                </el-form-item>
            </el-col>
        </el-row>
        <el-form-item>
            <el-button type="primary" @click="onSubmit">创建</el-button>
        </el-form-item>
    </el-form>
</template>

<script lang="ts" setup>
import axios from 'axios'
import { reactive, ref } from 'vue'
import store from '../../store'


const typeName = ref(null);

// do not use same name with ref
const form = reactive({
    id: 0,
    name: '',
    createdDate: '',
    author: '',
    booktypeId: 0,
})

const onSubmit = () => {
    form.booktypeId = typeName.value;
    console.log(JSON.stringify(form));
    axios({
        url: "https://localhost:7159/api/Book/PostAddBook",
        method: "Post",
        data: JSON.stringify(form),
        headers: {
            'Content-Type': "application/json"
        },
    }).then(function (resp) {
        store.state.BookInfos.push(resp.data)
    })
}
</script>

<style>
#addform>h3{
    text-align: center;
}
</style>