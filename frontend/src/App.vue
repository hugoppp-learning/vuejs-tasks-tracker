<template>

  <div class="container">
  <div class="container-border">
    <div style="display: flex; justify-content: center;flex-wrap:wrap;">
      <div style="margin-right:auto">
        <Header text="Tack tracker" style="margin-right:50px; white-space: nowrap"/>
      </div>
      <NewTaskForm @taskCreated="createTask"/>
    </div>
    <Tasks @delete-task="deleteTask" :tasks="tasks"/>
  </div>
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
  },
  methods:{
    async fetchTasks(){
      let req = await fetch('/api/TaskItem/All')
      return await req.json()
    },
    async deleteTask(id){

      let deleteMethod = {
        method: 'DELETE',
      }

      fetch('api/TaskItem/' + id , deleteMethod).then(r =>
      {
        if (r.ok)
          this.tasks = this.tasks.filter((x) => x.id !== id)
      });
    },

    async createTask(task){
      if (!task.title)
        return;

      let id = uuidv4();
      task = {id: id, title: task.title, description: task.description};
      console.log(id);
      let putMethod = {
        method: 'PUT',
        headers: {'content-type' : 'application/json; charset=UTF-8'},
        body: JSON.stringify(task),
      }
      fetch('api/TaskItem/', putMethod).then(r =>
      {
        if (r.ok)
          this.tasks.push(task);
      });
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
  /* background-color: #111111; */
}

.container{
  margin: 5px;
}

.container-border {
  display: flex; 
  flex-direction: column;

  max-width: 1000px;
  margin: 30px auto;
  /* overflow: auto; */
  min-height: 300px;
  border: 1px solid steelblue;
  padding: 30px;
  border-radius: 5px;
}
input{
  padding: 12px 20px;
  margin: 8px 0;
  font-size: 1em;
  box-sizing: border-box;

}
button {
  display: inline-block;
  border: none;
  padding: 10px 20px;
  margin: 5px;
  border-radius: 5px;
  cursor: pointer;
  text-decoration: none;
  font-size: 1em;
  font-family: inherit;
  justify-self: start; 

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
