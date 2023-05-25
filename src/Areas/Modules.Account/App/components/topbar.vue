<script>
export default{
  data(){
    
  },
 methods:{
   initFullScreen() {
     document.body.classList.toggle("fullscreen-enable");
     if (
         !document.fullscreenElement &&
         /* alternative standard method */ !document.mozFullScreenElement &&
         !document.webkitFullscreenElement
     ) {
       // current working methods
       if (document.documentElement.requestFullscreen) {
         document.documentElement.requestFullscreen();
       } else if (document.documentElement.mozRequestFullScreen) {
         document.documentElement.mozRequestFullScreen();
       } else if (document.documentElement.webkitRequestFullscreen) {
         document.documentElement.webkitRequestFullscreen(
             Element.ALLOW_KEYBOARD_INPUT
         );
       }
     } else {
       if (document.cancelFullScreen) {
         document.cancelFullScreen();
       } else if (document.mozCancelFullScreen) {
         document.mozCancelFullScreen();
       } else if (document.webkitCancelFullScreen) {
         document.webkitCancelFullScreen();
       }
     }
   },
   toggleMenu() {
     this.$parent.toggleMenu();
   },
 } 
}
</script>

<template>
  <header id="page-topbar">
    <div class="navbar-header" style="background-color: #fff; box-shadow: rgba(33, 35, 38, 0.1) 0px 10px 10px -10px;">
      <div class="d-flex">
        <!-- LOGO -->
        <div class="navbar-brand-box d-flex align-items-center justify-content-center" style="">
<!--          <router-link to="/" class="logo logo-dark">-->
<!--            <span class="logo-sm">-->
<!--              <img src="@/assets/images/logo-sm.png" alt height="22"/>-->
<!--            </span>-->
<!--            <span class="logo-lg">-->
<!--              <img src="@/assets/images/logo-dark.png" alt height="17"/>-->
<!--            </span>-->
<!--          </router-link>-->

<!--          <router-link to="/" class="logo logo-light d-flex align-items-center justify-content-center">-->
<!--            <span class="logo-sm">-->
<!--              <img src="@/assets/images/DTHU.png" class="logo-dthu-sm" alt="logo dthu"/>-->
<!--            </span>-->
<!--            <span class="logo-lg">-->
<!--              <img src="@/assets/images/d-office.png" alt height="35"/>-->
<!--            </span>-->
<!--          </router-link>-->
        </div>

        <button
            type="button"
            class="btn btn-sm px-3 font-size-24 header-item "
            id="vertical-menu-btn"
            @click="toggleMenu()"
        >
          <i class="mdi mdi-menu text-primary"></i>
        </button>
        <!--        <div class="d-none d-sm-block">-->
        <!--          <h5 class="pt-4 d-inline-block text-white fs-5 fw-medium">Trường Đại học Đồng Tháp</h5>-->
        <!--        </div>-->
        <div class="align-items-center d-none d-sm-flex cs-menu-top">
          <router-link
              tag="a"
              class-active="active"
              class="p-2 item-link"
              to="/xu-ly-van-ban-den"
              exact
          >
<!--            <p class="cs-item-topbar"> Văn bản đến</p>-->
<!--            <span :class="`badge rounded-pill bg-danger float-end`" class="cs-notify">{{subNotify.vanBanDen}}</span-->
<!--            >-->
          </router-link>
          <router-link
              tag="a"
              class-active="active"
              class="p-2 item-link"
              to="/xu-ly-van-ban-di"
              exact
          >
            <p class="cs-item-topbar">Ban hành văn bản</p>
<!--            <span :class=" `badge rounded-pill bg-danger float-end`" class="cs-notify">{{subNotify.vanBanDi}}</span>-->
          </router-link>
          <router-link
              tag="a"
              class-active="active"
              class="p-2 item-link"
              to="/thu-den"
              exact
          >
            <p class="cs-item-topbar">Hộp thư</p>
<!--            <span :class=" `badge rounded-pill bg-danger float-end`" class="cs-notify">{{subNotify.hopThu}}</span>-->
          </router-link>
          <router-link
              tag="a"
              class-active="active"
              class="p-2 item-link"
              to="/merge-thongbao"
              exact
          >
            <p class="cs-item-topbar">Thông báo</p>
<!--            <span :class="`badge rounded-pill bg-danger float-end`" class="cs-notify">{{subNotify.thongBao}}</span>-->
          </router-link>
        </div>
      </div>

      <div class="d-flex">

        <!--        <b-dropdown-->
        <!--          variant="white"-->
        <!--          class="d-inline-block"-->
        <!--          toggle-class="header-item noti-icon"-->
        <!--          menu-class="dropdown-menu-lg dropdown-menu-end"-->
        <!--        >-->
        <!--          <template v-slot:button-content>-->
        <!--            <i class="mdi mdi-magnify"></i>-->
        <!--          </template>-->
        <!--          <form class="p-3">-->
        <!--            <div class="form-group m-0">-->
        <!--              <div class="input-group">-->
        <!--                <input-->
        <!--                  type="text"-->
        <!--                  class="form-control"-->
        <!--                  placeholder="Search ..."-->
        <!--                  aria-label="Recipient's username"-->
        <!--                />-->
        <!--                <div class="input-group-append">-->
        <!--                  <button class="btn btn-primary" type="submit">-->
        <!--                    <i class="mdi mdi-magnify"></i>-->
        <!--                  </button>-->
        <!--                </div>-->
        <!--              </div>-->
        <!--            </div>-->
        <!--          </form>-->
        <!--        </b-dropdown>-->
        <!-- App Search-->

        <!--        <b-dropdown-->
        <!--          class="d-none d-md-block ms-2"-->
        <!--          toggle-class="header-item"-->
        <!--          menu-class="dropdown-menu-end"-->
        <!--          right-->
        <!--          variant="white"-->
        <!--        >-->
        <!--          <template v-slot:button-content>-->
        <!--            <img-->
        <!--              class="me-2"-->
        <!--              src="@/assets/images/flags/us_flag.jpg"-->
        <!--              alt="Header Language"-->
        <!--              height="16"-->
        <!--            />-->
        <!--            English-->
        <!--            <span class="mdi mdi-chevron-down"></span>-->
        <!--          </template>-->
        <!--          <a href="javascript:void(0);" class="dropdown-item notify-item">-->
        <!--            <img-->
        <!--              src="@/assets/images/flags/germany_flag.jpg"-->
        <!--              alt="user-image"-->
        <!--              class="me-1"-->
        <!--              height="12"-->
        <!--            />-->
        <!--            <span class="align-middle">German</span>-->
        <!--          </a>-->

        <!--          &lt;!&ndash; item&ndash;&gt;-->
        <!--          <a href="javascript:void(0);" class="dropdown-item notify-item">-->
        <!--            <img-->
        <!--              src="@/assets/images/flags/italy_flag.jpg"-->
        <!--              alt="user-image"-->
        <!--              class="me-1"-->
        <!--              height="12"-->
        <!--            />-->
        <!--            <span class="align-middle">Italian</span>-->
        <!--          </a>-->

        <!--          &lt;!&ndash; item&ndash;&gt;-->
        <!--          <a href="javascript:void(0);" class="dropdown-item notify-item">-->
        <!--            <img-->
        <!--              src="@/assets/images/flags/french_flag.jpg"-->
        <!--              alt="user-image"-->
        <!--              class="me-1"-->
        <!--              height="12"-->
        <!--            />-->
        <!--            <span class="align-middle">French</span>-->
        <!--          </a>-->

        <!--          &lt;!&ndash; item&ndash;&gt;-->
        <!--          <a href="javascript:void(0);" class="dropdown-item notify-item">-->
        <!--            <img-->
        <!--              src="@/assets/images/flags/spain_flag.jpg"-->
        <!--              alt="user-image"-->
        <!--              class="me-1"-->
        <!--              height="12"-->
        <!--            />-->
        <!--            <span class="align-middle">Spanish</span>-->
        <!--          </a>-->

        <!--          &lt;!&ndash; item&ndash;&gt;-->
        <!--          <a href="javascript:void(0);" class="dropdown-item notify-item">-->
        <!--            <img-->
        <!--              src="@/assets/images/flags/russia_flag.jpg"-->
        <!--              alt="user-image"-->
        <!--              class="me-1"-->
        <!--              height="12"-->
        <!--            />-->
        <!--            <span class="align-middle">Russian</span>-->
        <!--          </a>-->
        <!--        </b-dropdown>-->

        <div class="dropdown d-none d-lg-inline-block">
          <button
              type="button"
              class="btn header-item noti-icon"
              @click="initFullScreen"
          >
            <i class="mdi mdi-fullscreen text-primary"></i>
          </button>
        </div>
        <!-- ./start Notify -->
        <b-dropdown
            class="d-inline-block"
            toggle-class="header-item noti-icon"
            menu-class="dropdown-menu-lg p-0 dropdown-menu-end"
            right
            variant="white"
        >
<!--          <template v-slot:button-content>-->
<!--            <i class="mdi mdi-bell-outline text-primary"></i>-->
<!--            <span v-if="listNotify.number > 0" class="badge bg-danger rounded-pill">{{ listNotify.number }}</span>-->
<!--          </template>-->
<!--          <div class="p-3">-->
<!--            <div class="row align-items-center">-->
<!--              <div class="col">-->
<!--                <p class="m-0 font-size-16 fw-bold text-black">Thông báo</p>-->
<!--              </div>-->
<!--              &lt;!&ndash;              <div class="col-auto">&ndash;&gt;-->
<!--              &lt;!&ndash;                <a href="/thong-bao" class="small"> Tất cả </a>&ndash;&gt;-->
<!--              &lt;!&ndash;              </div>&ndash;&gt;-->
<!--            </div>-->
<!--          </div>-->
<!--          <simplebar style="max-height: 300px">-->
<!--            <a-->
<!--                href="javascript: void(0);"-->
<!--                class="text-reset notification-item"-->
<!--                v-for="items in listNotify.listNotify"-->
<!--                :key="items.id"-->
<!--                @click="handleNotifyDetail(items.id),handleDetailUser(items.senderId),handleChangeStatus(items.id)"-->
<!--            >-->
<!--              <div>-->
<!--                <div class="d-flex align-items-center">-->
<!--                  <div class="avatar-xs me-3">-->
<!--                    <span-->
<!--                        class="bg-primary rounded-circle font-size-16 text-light p-2 mt-2"-->
<!--                    >-->
<!--                      <i class="fas fa-scroll"></i>-->
<!--                    </span>-->
<!--                  </div>-->
<!--                  <div class="flex-grow-1 notify-content-box px-2">-->
<!--                    <h6 class="mt-0 mb-1  title-capso" :inner-html.prop="items.title | truncate(60)">-->

<!--                    </h6>-->

<!--                    <div class="font-size-12 text-muted ntf-content">-->
<!--                      <p class="mb-1" :inner-html.prop="items.content | truncate(60)">-->
<!--                      </p>-->
<!--                    </div>-->
<!--                  </div>-->
<!--                  <div class="icon-box p-2">-->
<!--                    <i v-if="items.read == true" class="bx bxs-circle text-light"></i>-->
<!--                    <i v-else-if="items.read == false" class="bx bxs-circle text-primary"></i>-->
<!--                  </div>-->
<!--                </div>-->
<!--              </div>-->
<!--            </a>-->

<!--          </simplebar>-->
          <div class="p-2 border-top">
            <div class="d-grid">
              <a
                  class="btn btn-sm btn-link font-size-14 text-center"
                  href="javascript:void(0)"
                  @click=""
              >
                Xem tất cả
              </a>
            </div>
          </div>
        </b-dropdown>
        <!-- ./ end Notify -->
        <b-dropdown
            class="d-inline-block"
            right
            toggle-class="header-item"
            variant="white"
            menu-class="dropdown-menu-end dropdown-menu-lg p-0"

        >
          <!--          <template v-slot:button-content>-->
          <!--            <img-->
          <!--              class="rounded-circle header-profile-user"-->
          <!--              src="@/assets/images/users/user-4.jpg"-->
          <!--              alt="Header Avatar"-->
          <!--            />-->

          <!--          </template>-->
          <template v-slot:button-content>
            <div style="display:flex; justify-content:center; align-content:center">
                         <span>
<!--              <span v-if="currentUserAuth.avatar">-->
<!--                <b-img-->
<!--                    :src=" url + `${currentUserAuth.avatar.fileId}`"-->
<!--                    alt="Avatar"-->
<!--                    class="rounded-circle header-profile-user"-->
<!--                >-->
<!--                </b-img>-->
<!--              </span>-->
<!--              <span v-else>-->
<!--                <img-->
<!--                    class="rounded-circle header-profile-user"-->
<!--                    src="@/assets/images/users/user-4.jpg"-->
<!--                    alt="Avatar"-->
<!--                />-->
<!--              </span>-->
            </span>&nbsp;
              <span class="d-none d-xl-inline-block ms-1">
<!--              <div v-if="currentUserAuth" style="font-size: 10px;">-->
<!--                <div style="font-size: 12px" class="text-primary">-->
<!--                  {{ currentUserAuth.fullName }}-->
<!--                  <i class="mdi mdi-chevron-down d-none d-xl-inline "></i>-->
<!--                </div>-->
<!--                <div class="text-start text-dark">-->
<!--                  @{{ currentUserAuth.userName }}-->
<!--                </div>-->
<!--              </div>-->
<!--              <div v-else>-->
<!--               AnhDev99-->
<!--              </div>-->
              </span
              >
            </div>

          </template>

          <!--  dropdown profile -->
          <div class="overflow-hidden cs-shadow-profile">
            <div class="bg-soft bg-soft-dark custom-image">
              <div class="row">
                <div class="col-12" style="height: 100px">
                  <div class="text-primary p-2 text-center">
                    <!--                    <h5 class="text-dark text-uppercase py-3">Người dùng</h5>-->
                  </div>
                </div>
              </div>
            </div>
            <div class="pt-0 mb-3">
              <div class="row">
                <div class="col-sm-12 align-self-center">
                  <div class="avatar-md profile-user-wid mb-2 w-100 d-flex flex-column align-items-center">
                    <div style="margin-top: -35px;">
<!--                      <div v-if="currentUserAuth.avatar">-->
<!--                        <b-img-->
<!--                            :src=" url + `${currentUserAuth.avatar.fileId}`"-->
<!--                            alt-->
<!--                            class="img-thumbnail rounded-circle"-->
<!--                            style="height: 72px ; width: 72px"-->
<!--                        >-->
<!--                        </b-img>-->
<!--                      </div>-->
<!--                      <div v-else>-->
<!--                        <img-->
<!--                            class="img-thumbnail rounded-circle"-->
<!--                            style="height: 72px ; width: 72px"-->
<!--                            alt-->
<!--                            src="@/assets/images/4.png"-->
<!--                        />-->
<!--                      </div>-->
                    </div>
<!--                    <div v-if="currentUserAuth" class="text-center">-->
<!--                      <h5 class="font-size-15 text-dark fw-bold">{{ currentUserAuth.fullName }}</h5>-->
<!--                      <p class="mb-0 text-dark">@{{ currentUserAuth.userName }}</p>-->
<!--                    </div>-->
                  </div>
                </div>

                <!--              <div class="col-sm-6">-->
                <!--                <div class="pt-4">-->
                <!--                  <div class="row">-->
                <!--                    <div class="col-6">-->
                <!--                      <h5 class="font-size-15">125</h5>-->
                <!--                      <p class="text-muted mb-0">Projects</p>-->
                <!--                    </div>-->
                <!--                    <div class="col-6">-->
                <!--                      <h5 class="font-size-15">$1245</h5>-->
                <!--                      <p class="text-muted mb-0">Revenue</p>-->
                <!--                    </div>-->
                <!--                  </div>-->
                <!--                </div>-->
                <!--              </div>-->
              </div>
            </div>
            <b-dropdown-item>
              <a v-on:click="">
                <i
                    class="mdi mdi-account-circle font-size-17 align-middle me-1"
                ></i>
                Thông tin cá nhân
              </a>
            </b-dropdown-item>
            <div class="dropdown-divider"></div>
            <a class="dropdown-item text-danger mb-2" v-on:click="" style="cursor: pointer;">
              <i
                  class="mdi mdi-logout font-size-17 align-middle me-1"
              ></i>
              Đăng xuất
            </a>
          </div>
          <!-- end dropdown profile -->


        </b-dropdown>
      </div>
    </div>
  </header>
</template>