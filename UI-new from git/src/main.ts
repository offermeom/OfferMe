import App from './App.vue'
import { createApp } from 'vue'
import router from './router'
import vuetify from '@/plugins/vuetify.config'
import { createPinia } from 'pinia'
import './assets/main.css'
const app = createApp(App)
app.use(router)
app.use(vuetify)
app.use(createPinia())
app.mount('#app')
