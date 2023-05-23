<template>
  <default-layout>
    <b-container class="test-global-css test-scoped-css">
      <h1 style="color: red">Nguyễn Tuấn Kiệt</h1>
    </b-container>
  </default-layout>
</template>
<script>
export default {
  name: "HelloWorld",
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