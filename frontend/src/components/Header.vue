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
    align-items: center;
    margin-bottom: 20;
  }
</style>

