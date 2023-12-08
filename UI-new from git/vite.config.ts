import { fileURLToPath, URL } from 'node:url'
import { defineConfig } from 'vite'
import legacy from '@vitejs/plugin-legacy'
import vue from '@vitejs/plugin-vue'
import vueJsx from '@vitejs/plugin-vue-jsx'
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    vueJsx(),
    legacy({
      targets: ["ie >= 11"],
      additionalLegacyPolyfills: ["regenerator-runtime/runtime"]
    })
  ],
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url)),
      '@v': fileURLToPath(new URL('./src/views', import.meta.url)),
      '@s': fileURLToPath(new URL('./src/services', import.meta.url)),
      '@c': fileURLToPath(new URL('./src/components', import.meta.url)),
      '@t': fileURLToPath(new URL('./src/components/__tests__', import.meta.url))
    }
  }
})
