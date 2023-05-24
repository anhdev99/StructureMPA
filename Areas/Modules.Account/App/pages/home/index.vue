<template>
  <default-layout>
    <h1 class="title"> Tuấn Kiệt</h1>
    <button type="button" class="btn btn-primary w-md">
      Add Order
    </button>
    <div class="col-lg-4 d-none d-lg-block">
      <div class="clearfix mt-4 mt-lg-0">
        <b-dropdown
            class="float-end"
            right
            variant="primary"
            menu-class="dropdown-menu-end"
        >
          <template v-slot:button-content>
            <i class="bx bxs-cog align-middle me-1"></i> Setting
          </template>
          <b-dropdown-item>Action</b-dropdown-item>
          <b-dropdown-item>Another action</b-dropdown-item>
          <b-dropdown-item>Something else</b-dropdown-item>
        </b-dropdown>
      </div>
    </div>
    <router-link to="Account/dang-nhap"> Dang Nhap</router-link>
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