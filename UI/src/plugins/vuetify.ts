import Vue from 'vue'
import Vuetify from 'vuetify';
import 'vuetify/dist/vuetify.min.css';
import '@mdi/font/css/materialdesignicons.css' // Ensure you are using css-loader

Vue.use(Vuetify);
const opts = {};
// export default new Vuetify(opts);
export default new Vuetify({
  theme: {
    themes: {
      light: {
        primary: '#379AFF', // Replace with your custom primary color
        secondary: '#424242',
        accent: '#82B1FF',
        error: '#FF5252',
        info: '#2196F3',
        success: '#4CAF50',
        warning: '#FFC107',
      },
    },
  },
});
