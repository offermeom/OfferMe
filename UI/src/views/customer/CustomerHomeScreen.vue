<template>
  <v-container>
    <div class="c-screen d-flex justify-center">
      <div>
        <v-btn
          depressed
          color="primary"
          class="d-block mx-auto my-auto white--text"
          width="150px"
          @click="goToVendorLogin()"
        >
          Vendor
        </v-btn>
        <div class="d-flex justify-center">
          <div class="my-4 d-inline-flex align-center">
            <v-divider width="55px"></v-divider>
            <h4 class="text-center grey--text mx-2">Or</h4>
            <v-divider width="55px"></v-divider>
          </div>
        </div>
        <v-btn
          depressed
          color="primary"
          outlined
          class="d-block mx-auto my-auto"
          width="150px"
          @click="goToCustomerLogin()"
        >
          Customer
        </v-btn>
      </div>
    </div>
  </v-container>
</template>

<script lang="ts">
export default {
  methods: {
    goToVendorLogin() {
      this.$router.push('/loginvendor')
    },
    goToCustomerLogin() {
      this.$router.push('/logincustomer')
    }
  }
}
</script>

<style>
#app {
  padding: 0px !important;
}

.v-application--wrap {
  justify-content: center;
}
</style>
