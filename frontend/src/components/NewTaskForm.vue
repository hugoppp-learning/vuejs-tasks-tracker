<template>
  <div class="NewTakForm" style="display:flex; flex-wrap:wrap; justify-content:center; justify-self:center">
    <div style="display: flex; flex-wrap:wrap; justify-content:center;">
      <input v-model="newTask.title" placeholder="title">
      <input v-model="newTask.description" placeholder="description">
    </div>
    <button style="display-flex;" @click="this.$emit('taskCreated', newTask )">Add</button> 
  </div>
</template>

<script>

export default {
  name: 'NewTaskForm',
  data(){
    return{
      newTask: {
        title: '',
        description: ''
      }
    }
  }
}
</script>


<style scoped>
input{
   margin: 10px; 
}
</style>
