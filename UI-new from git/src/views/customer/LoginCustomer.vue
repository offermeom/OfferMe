<template>
  <v-app>
    <v-container class="d-block my-auto">
      <div elevation="2">
        <h2 class="primary--text">Login as Customer</h2>
        <div>
          <v-form @submit.prevent="login">
            <v-text-field
              prepend-icon="mdi-account"
              :rules="[requiredRule]"
              name="login"
              label="User Name"
              type="text"
              v-model="username"
            ></v-text-field>
            <v-text-field
              id="password"
              :rules="[requiredRule]"
              prepend-icon="mdi-lock"
              name="password"
              label="Password"
              type="password"
              v-model="password"
            ></v-text-field>
            <v-btn
              color="primary"
              class="white--text d-block mx-auto my-auto"
              @click="loginCustomerHome()"
            >
              Login
            </v-btn>
          </v-form>
        </div>
      </div>
      <v-btn
        depressed
        color="primary"
        outlined
        class="d-block mx-auto my-auto mt-12"
        @click="registerCustomer()"
      >
        Register as Customer
      </v-btn>
    </v-container>
  </v-app>
</template>

<script lang="ts">
export default {
  data() {
    return {
      username: '',
      password: '',
      requiredRule: [(v) => !!v || 'This field is required']
    }
  },
  methods: {
    loginCustomerHome() {
      this.$router.push('/logincustomerhome')
    },
    registerCustomer() {
      this.$router.push('/registercustomer')
    }
  }
}
</script>

<style>
#app {
  padding: 0px;
}
</style>
