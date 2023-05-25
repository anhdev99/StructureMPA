export const menuItems = [
    {
        id: 1,
        label: "Bảng điều khiển",
        isTitle: true
    },
    {
        id: 2,
        label: " Thiết kế mẫu BC",
        icon: "bx-home-circle",
        subItems: [
            {
                id: 3,
                label: "Nhóm chỉ tiêu",
                link: "/",
                parentId: 2
            },
            {
                id: 4,
                label: "Mẫu báo cáo",
                link: "/dashboard/saas",
                parentId: 2
            },
            {
                id: 5,
                label: "Nhóm thuộc tính",
                link: "/dashboard/crypto",
                parentId: 2
            }
        ]
    },
    {
        id: 7,
        isLayout: true
    },
    {
        id: 8,
        label: "Quản trị hệ thống",
        isTitle: true
    },
    {
        id: 9,
        label: "Quản trị danh mục",
        icon: "bx-calendar",
        link: "/calendar"
    },
    {
        id: 10,
        label: "Quản lý lịch công ta",
        icon: "bx-chat",
        link: "/chat",
    },
    {
        id: 11,
        label: "Quản lý CT sản xuất",
        link: "/apps/file-manager",
        icon: "bx-file",
    },
];