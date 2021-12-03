<template>
  <div class="container">
    <Tasks :tasks="tasks"/>
  </div>
</template>

<script>
import Tasks from './components/Tasks.vue'

export default {
  name: 'App',
  components: {
    Tasks 
  },
  data() {
    return {
     tasks: [ ] 
    }
  },
  created(){
    this.tasks = [
      {id: 0, text: "tasks0", description: "a description" },
      {id: 1, text: "tasks1", description: "a description" },
      {id: 2, text: "tasks2", description: "a description" },
    ]
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
