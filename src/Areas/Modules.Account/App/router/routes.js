const module = "/Account";
let router = [
    {
        path: "/",
        name: "default",
        meta: {},
        component: () =>  import("../pages/home/index.vue"),
    },
    {
        path: "/dang-nhap",
        name: "login",
        meta: {},
        component: () =>  import("../pages/auth/login.vue"),
    }
]

export default router.map((value) =>{
    value.path = "/Account" + value.path;
    return value;
})