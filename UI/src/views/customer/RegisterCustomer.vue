<template>
  <v-app>
    <v-container class="d-block my-auto">
      <div elevation="2">
        <h2 class="primary--text mb-3">Register as Customer</h2>
        <div>
          <v-form v-model="valid" @submit.prevent="registerUser">
            <v-text-field
              prepend-icon="mdi-account"
              v-model="name"
              :rules="nameRules"
              label="User Name"
              required
            ></v-text-field>
            <v-text-field
              prepend-icon="mdi-email"
              v-model="email"
              :rules="emailRules"
              label="Email"
              required
            ></v-text-field>
            <v-text-field
              prepend-icon="mdi-phone"
              v-model="phone"
              :rules="phoneRules"
              label="Phone Number"
              required
            ></v-text-field>
            <v-text-field
              prepend-icon="mdi-lock"
              v-model="password"
              :rules="passwordRules"
              label="Password"
              type="password"
              required
            ></v-text-field>
            <v-text-field
              prepend-icon="mdi-lock"
              v-model="confirmPassword"
              :rules="confirmPasswordRules"
              label="Confirm Password"
              type="password"
              required
            ></v-text-field>
            <v-btn
              type="submit"
              :disabled="!valid"
              color="primary"
              class="white--text d-block mx-auto my-auto"
              @click="registerCustomerHome()"
            >
              Register
            </v-btn>
          </v-form>
        </div>
      </div>
      <v-btn
        depressed
        color="primary"
        outlined
        class="d-block mx-auto my-auto mt-12"
        @click="loginCustomer()"
      >
        Login as Customer
      </v-btn>
    </v-container>
  </v-app>
</template>

<style>
#app {
  padding: 0px !important;
  margin: auto 7px;
}
</style>

<script lang="ts">
export default {
  methods: {
    loginCustomer() {
      this.$router.push('/logincustomer')
    },
    registerCustomerHome() {
      this.$router.push('/registercustomer')
    }
  },

  name: 'RegisterUser',
  data() {
    return {
      name: '',
      email: '',
      phone: '',
      password: '',
      confirmPassword: '',
      valid: false,
      nameRules: [
        (v) => !!v || 'Name is required',
        (v) => (v && v.length <= 20) || 'Name must be less than 20 characters'
      ],
      emailRules: [
        (v) => !!v || 'Email is required',
        (v) => /.+@.+/.test(v) || 'Email must be valid'
      ],
      phoneRules: [
        (v) => !!v || 'Phone Number is required',
        (v) => (v && v.length == 10) || 'Enter 10 digit valid Phone Number'
      ],
      passwordRules: [
        (v) => !!v || 'Password is required',
        (v) => (v && v.length >= 8) || 'Password must be at least 8 characters'
      ],
      confirmPasswordRules: [
        (v) => !!v || 'Confirm password is required',
        (v) => v === this.password || 'Passwords must match'
      ]
    }
  }
}
</script>
