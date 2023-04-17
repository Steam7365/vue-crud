<template>
    <div class="bookInfo">
        <BookHead class="bHead"></BookHead>
        <BookBody class="bBody"></BookBody>
    </div>
</template>

<script>
import BookHead from "../components/Book/BookHead.vue";
import BookBody from "../components/Book/BookBody.vue";
export default {
    components: {
        BookHead, BookBody
    },
};
</script>

<style>
.bookinfo {
    text-align: center;
}

.bBody,
.bUpdate {
    margin-top: 30px;
}

.bUpdate {
    width: 500px;
}
</style>