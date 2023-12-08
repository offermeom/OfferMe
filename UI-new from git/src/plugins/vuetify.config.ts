import { createVuetify } from 'vuetify'
import 'vuetify/styles'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'
const vuetify = createVuetify({
  ssr: true,
  components,
  directives,
  // You can customize Vuetify's theme, options, and more here
  theme: {
    themes: {
      light: {
        primary: '#379AFF', // Replace with your custom primary color
        secondary: '#424242',
        accent: '#82B1FF',
        error: '#FF5252',
        info: '#2196F3',
        success: '#4CAF50',
        warning: '#FFC107'
      }
    }
  }
})

export default vuetify
