import { createRouter, createWebHistory } from 'vue-router'
import ChoiceScreenVue from '@/views/ChoiceScreen.vue'
import TestDataView from '@/Playground/TestDataView.vue'
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    // {
    //   path: '/',
    //   name: 'home',
    //   component: HomeView
    // },
    // {
    //   path: '/about',
    //   name: 'about',
    //   route level code-splitting
    //   this generates a separate chunk (About.[hash].js) for this route
    //   which is lazy-loaded when the route is visited.
    //   component: () => import('../views/AboutView.vue')
    // }
    {
      path: '/test',
      name: 'test',
      component: TestDataView
    },
    {
      path: '/',
      name: 'home',
      component: ChoiceScreenVue
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
    }
  ]
})

export default router
