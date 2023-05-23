<template>
  <default-layout>
    <b-container class="test-global-css test-scoped-css">
      sadsa
      <h1 class="title"> Tuấn Kiệt</h1>
    </b-container>
  </default-layout>
</template>

<script>
export default {
  data() {
    return {
      name: "world"
    }
  },
}
</script>

<style scoped lang="scss">
$fontColor: #FFF;
.test-scoped-css {
  color: $fontColor;
}

</style>