<template>
  <div>
    <h3>{{task.text}}</h3> 
    <p>{{task.description}}</p>
  </div>
</template>

<script>
export default {
  name: 'Task',
  props: {
    task: Object
  }
}
</script>
