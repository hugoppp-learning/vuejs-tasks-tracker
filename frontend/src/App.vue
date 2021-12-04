<template>
  <div class="container">
    <NewTaskForm @taskCreated="createTask"/>
    <Header text="Tack tracker"/>
    <Tasks @delete-task="deleteTask" :tasks="tasks"/>
  </div>
</template>

<script>
import Tasks from './components/Tasks.vue'
import Header from './components/Header.vue'
import NewTaskForm from './components/NewTaskForm.vue'
import { v4 as uuidv4 } from 'uuid'

export default {
  name: 'App',
  components: {
    Tasks,
    Header,
    NewTaskForm
  },
  data() {
    return {
     tasks: [ ] 
    }
  },
  async created() {
    this.tasks = await this.fetchTasks();
    /* this.tasks = [ */
    /*   {id: 0, text: "tasks0", description: "a description" }, */
    /*   {id: 1, text: "tasks1", description: "a description" }, */
    /*   {id: 2, text: "tasks2", description: "a description" }, */
    /* ] */
  },
  methods:{
    async fetchTasks(){
      let req = await fetch('https://localhost:7276/TaskItem/All')
      return await req.json()
    },
    deleteTask(id){
      console.log('deleteing Task with id ' + id)
      this.tasks = this.tasks.filter((x) => x.id !== id)
    },
    createTask(task){
      if (task.title)
        this.tasks.push({id: uuidv4(), title: task.title, description: task.description});
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
