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
              to="vendorhomescreen"
              router
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
        to="registervendor"
        router
      >
        Register as Vendor
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
      gstin: '',
      requiredRule: [(v: String) : Boolean | String => !!v || 'This field is required']
    }
  }
}
</script>

<style lang="stylus">
#app
  padding 0px !important
.container
  padding 10px 20px !important
</style>
