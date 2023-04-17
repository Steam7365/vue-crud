<script setup>
import { RouterLink, RouterView } from 'vue-router'
//http://localhost:5173/
</script>

<script>
import store from './store/index.js'
await store.dispatch('GetAllBookTypesAction');
</script>

<template>
  <header>
    <div>
      <nav>
        <RouterLink to="/"></RouterLink>
        <RouterLink to="/"></RouterLink>
        <!-- <RouterLink to="/booktest">aaa</RouterLink> -->
        <!-- <RouterLink to="/book">book</RouterLink> -->
      </nav>
    </div>
  </header>

  <RouterView />
</template>

<style scoped>

</style>
