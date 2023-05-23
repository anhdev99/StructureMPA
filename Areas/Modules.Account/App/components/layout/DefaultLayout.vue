<template>
  <div id="layout-wrapper">
    <div class="main-content">
      <div class="page-content">
        <div class="container-fluid" style="padding: 10px 0px">
        
          <div class="row">
            <div class="col-12">
              <div class="card">
                <div class="card-body">
                  <!-- CK-editor -->
                  <slot />
                </div>
              </div>
            </div>
            <!-- end col -->
          </div>
        </div>
      </div>
      <Footer />
    </div>
  </div>
</template>

<script>
export default {
  name: "LayoutContainer"
}
</script>

<style scoped>

</style>