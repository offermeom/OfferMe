<template>
  <v-app>
    <v-container class="d-block my-auto">
      <div elevation="2">
        <h2 class="primary--text">Login as Vendor</h2>
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
              prepend-icon="mdi-note-text"
              :rules="[requiredRule]"
              name="gstin"
              label="GSTIN"
              type="text"
              v-model="gstin"
            ></v-text-field>
            <v-text-field
              id="password"
              prepend-icon="mdi-lock"
              :rules="[requiredRule]"
              name="password"
              label="Password"
              type="password"
              v-model="password"
            ></v-text-field>
            <v-btn
              color="primary"
              class="white--text d-block mx-auto my-auto"
              @click="loginVendorHome()"
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
        @click="registerVendor()"
      >
        Register as Vendor
      </v-btn>
    </v-container>
  </v-app>
</template>

<style>
#app {
  padding: 0px !important;
}

.container {
  padding: 10px 20px !important;
}
</style>

<script lang="ts">
export default {
  data() {
    return {
      username: '',
      password: '',
      gstin: '',
      requiredRule: [(v) => !!v || 'This field is required']
    }
  },
  methods: {
    loginVendorHome() {
      this.$router.push('/vendorhomescreen')
    },
    registerVendor() {
      this.$router.push('/registervendor')
    }
  }
}
</script>

<style>
#app {
  padding: 0px;
}
</style>
