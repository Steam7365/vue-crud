// store.js 文件
import { createStore } from 'vuex'
import axios from 'axios'

const store = createStore({
    state: {

        BookInfos: {},
        BookInfo: {},
        BookTypes: {},
        Bookindex:0,
    },
    mutations: {
        GetAllBookTypes(state, bookTypeAll) {
            state.BookTypes = bookTypeAll;
        }
    },
    actions: {
        async GetAllBookTypesAction(context) {
            await axios({
                url: "https://localhost:7159/api/BookType",
                method: "get"
            }).then(function (resp) {
                context.commit("GetAllBookTypes", resp.data);
            })
        }
    }
})

export default store