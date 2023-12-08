import Vue from "vue";
import VueRouter from "vue-router";

Vue.use(VueRouter);

const router = new VueRouter({
  mode: "history",
  base: import.meta.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: () => import('../views/ChoiceScreen.vue')
    },
    {
      path: '/loginvendor',
      name: 'loginvendor',
      component: () => import('../views/vendor/LoginVendor.vue')
    },
    {
      path: '/registervendor',
      name: 'registervendor',
      component: () => import('../views/vendor/RegisterVendor.vue')
    },
    {
      path: '/vendorhomescreen',
      name: 'vendorhomescreen',
      component: () => import('../views/vendor/VendorHomeScreen.vue')
    },
    {
      path: '/vendoraddoffer',
      name: 'vendoraddoffer',
      component: () => import('../views/vendor/VendorAddOffer.vue')
    },
    {
      path: '/vendorviewoffer',
      name: 'vendorviewoffer',
      component: () => import('../views/vendor/VendorViewOffer.vue')
    },


    // Customer screens starts here
    {
      path: '/logincustomer',
      name: 'logincustomer',
      component: () => import('../views/customer/LoginCustomer.vue')
    },
    {
      path: '/registercustomer',
      name: 'registercustomer',
      component: () => import('../views/customer/RegisterCustomer.vue')
    },
    {
      path: '/customerhomescreen',
      name: 'customerhomescreen',
      component: () => import('../views/customer/CustomerHomeScreen.vue')
    },
  ],
});

export default router;
