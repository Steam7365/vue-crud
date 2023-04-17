<template>
    <div class="mt-4">
        <el-input v-model="input3" placeholder="Please input" class="input-with-select">
            <template #prepend>
                <el-button :icon="Search" />
            </template>
            <template #append>
                <el-select v-model="select" placeholder="选择查询条件" style="width: 115px">
                    <el-option label="编号查询" value="1" />
                    <el-option label="作者查询" value="2" />
                    <el-option label="书名查询" value="3" />
                </el-select>
            </template>
        </el-input>
    </div>
</template>

<script setup lang="ts">
import { ref } from 'vue'
import { Search } from '@element-plus/icons-vue'
const input3 = ref('')
const select = ref('')
</script>

<style>
.input-with-select .el-input-group__prepend {
    background-color: var(--el-fill-color-blank);
}
</style>