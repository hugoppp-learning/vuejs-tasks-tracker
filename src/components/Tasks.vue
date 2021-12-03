<template>
  <div class="container">
  <div :key="task.id" v-for="task in tasks" style="border: 1px solid black">
    <Task :task="task"/>
  </div> 
</div>
</template>


<script>
import Task from './Task.vue'

export default {
  name: 'Tasks',
  props: {
    tasks: Array
  },
  components: {
    Task
  }
}
</script>
