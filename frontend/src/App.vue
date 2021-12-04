<template>
  <div class="container">
    <Header text="Tack tracker"/>
    <Tasks @delete-task="deleteTask" :tasks="tasks"/>
  </div>
</template>

<script>
import Tasks from './components/Tasks.vue'
import Header from './components/Header.vue'

export default {
  name: 'App',
  components: {
    Tasks,
    Header
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
  },
  methods:{
    deleteTask(id){
      console.log('deleteing Task with id ' + id)
      this.tasks = this.tasks.filter((x) => x.id !== id)
    }
  },
}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300;400&display=swap');

* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}
body {
  font-family: 'Poppins', sans-serif;
}
.container {
  max-width: 500px;
  margin: 30px auto;
  overflow: auto;
  min-height: 300px;
  border: 1px solid steelblue;
  padding: 30px;
  border-radius: 5px;
}
.btn {
  display: inline-block;
  background: #000;
  color: #fff;
  border: none;
  padding: 10px 20px;
  margin: 5px;
  border-radius: 5px;
  cursor: pointer;
  text-decoration: none;
  font-size: 15px;
  font-family: inherit;
}
.btn:focus {
  outline: none;
}
.btn:active {
  transform: scale(0.98);
}
.btn-block {
  display: block;
  width: 100%;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
