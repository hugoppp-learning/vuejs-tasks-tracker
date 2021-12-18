<template>
  <header>
    <h1>{{ text }}</h1>
  </header>
</template>

<script>

export default {
  name: 'Header',
  props: {
    text: {
      type: String,
      default: 'no text for this header'
    }
  }
}

</script>

<style scoped>
  header{
    display: flex;
    justify-content: space-between;
    margin-bottom: 20;
    flex-shrink: 0;
  }
</style>

