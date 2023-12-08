import API from '../plugins/axios.config'
const Post = async (number: number, password: string) => {
  try {
    const r = await API.post('/SignIn', {
      Number: number,
      Password: password
    })
    return r.data
  } catch (e) {
    return e
  }
}

export default Post
