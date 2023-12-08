import axios from 'axios'
const API = axios.create({
  baseURL: 'http://localhost:5266/',
  timeout: 10000, // Request timeout in milliseconds
  headers: {
    'Content-Type': 'application/json'
  }
})
export default API
