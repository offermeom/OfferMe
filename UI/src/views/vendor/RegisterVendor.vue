<template>
    <v-app>
        <v-container class="d-block my-auto">
            <div
            elevation="2"
            >
            <h2 class="primary--text mt-4">Register as Vendor</h2>
            <div>
              <v-form v-model="valid" @submit.prevent="registerUser">
                <v-text-field
                    v-model="name"
                    prepend-icon="mdi-account"
                    :rules="nameRules"
                    label="User Name"
                    required
                ></v-text-field>
                <v-text-field
                    v-model="email"
                    prepend-icon="mdi-email"
                    :rules="emailRules"
                    label="Email"
                    required
                ></v-text-field>
                <v-text-field
                    v-model="phone"
                    prepend-icon="mdi-phone"
                    :rules="phoneRules"
                    label="Phone Number"
                    required
                ></v-text-field>
                <v-text-field
                    v-model="gst"
                    prepend-icon="mdi-note-text"
                    :rules="gstRules"
                    label="GSTIN"
                    required
                ></v-text-field>
                <v-text-field
                    v-model="confirmGst"
                    prepend-icon="mdi-note-text"
                    :rules="confirmGstRules"
                    label="Confirm GSTIN"
                    type="text"
                    required
                ></v-text-field>
                <v-text-field
                    v-model="password"
                    prepend-icon="mdi-lock"
                    :rules="passwordRules"
                    label="Password"
                    type="password"
                    required
                ></v-text-field>
                <v-text-field
                    v-model="confirmPassword"
                    prepend-icon="mdi-lock"
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
                @click="registerVendorHome()"
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
            class="d-block mx-auto my-auto mt-7"
            @click="loginVendor()"
            >
            Login as Vendor
            </v-btn> 
        </v-container>
    </v-app>
</template>

<style>
#app {
    margin: 0px;
    padding: 0px !important;
}
</style>

<script>
export default {
    methods:{
    loginVendor(){
    this.$router.push('/loginvendor'); 
    },
    registerVendorHome(){
    this.$router.push('/registervendor'); 
    },
  },

   name: 'RegisterUser',
  data() {
    return {
      name: '',
      email: '',
      phone:'',
      gst:'',
      confirmGst:'',
      password: '',
      confirmPassword: '',
      valid: false,
      nameRules: [
        v => !!v || 'Name is required',
        v => (v && v.length <= 20) || 'Name must be less than 20 characters',
      ],
      emailRules: [
        v => !!v || 'Email is required',
        v => /.+@.+/.test(v) || 'Email must be valid',
      ],
      phoneRules: [
        v => !!v || 'Phone Number is required',
        v => (v && v.length == 10) || 'Enter 10 digit valid Phone Number',
      ],
      gstRules: [
        v => !!v || 'GSTIN is required',
      ],
      confirmGstRules: [
        v => !!v || 'GSTIN is required',
        v => v === this.gst|| 'GSTIN must match',
      ],
      passwordRules: [
        v => !!v || 'Password is required',
        v =>
          (v && v.length >= 8) ||
          'Password must be at least 8 characters',
      ],
      confirmPasswordRules: [
        v => !!v || 'Confirm password is required',
        v => v === this.password || 'Passwords must match',
      ],
    };
  },
}
</script>