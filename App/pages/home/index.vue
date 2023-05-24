<template>
  <default-layout>
    <h1 class="title"> File Manager</h1>
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
    <div class="row">
      <div class="col-lg-6">
        <div class="card">
          <div class="card-body">
            <h4 class="card-title">Rounded buttons</h4>
            <p class="card-title-desc">
              Use
              <code>pill</code> for button round border.
            </p>
            <div class="button-items">
              <b-button pill variant="primary">Primary</b-button>
              <b-button pill variant="secondary">Secondary</b-button>
              <b-button pill variant="success">Success</b-button>
              <b-button pill variant="info">Info</b-button>
              <b-button pill variant="warning">Warning</b-button>
              <b-button pill variant="danger">Danger</b-button>
              <b-button pill variant="dark">Dark</b-button>
              <b-button pill variant="link">Link</b-button>
              <b-button pill variant="light">Light</b-button>
            </div>
          </div>
        </div>
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