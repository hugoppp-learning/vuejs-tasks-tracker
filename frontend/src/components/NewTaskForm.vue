<template>
  <div class="NewTakForm">
    <input v-model="newTask.title" placeholder="title">
    <input v-model="newTask.description" placeholder="description">
   <button @click="this.$emit('taskCreated', newTask )">Add</button> 
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
