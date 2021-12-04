<template>
  <div class="task">
    <h3>
      {{task.title}}
      <font-awesome-icon class="icon-times" icon="times" 
        @click="$emit('delete-task',task.id)"
      />
    </h3> 
    <p>{{task.description}}</p>
  </div>
</template>

<script>
export default {
  name: 'Task',
  props: {
    task: Object
  },
}
</script>

<style scoped>

.icon-times {
  color: red;
  font-size: 120%; 
}

.task{
  border: 1px solid black;
  border-radius: 5px;
  background: whitesmoke;
  padding: 5px 10px;
  margin: 10px 0px ;
}

.task h3{
  display: flex;
  align-items: center;
  justify-content: space-between; 
}

p {
  display: flex;
  padding-left: 5%; 
}

</style>

