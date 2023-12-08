import { describe, it, expect } from 'vitest'
import { mount } from '@vue/test-utils'
import ChoiceScreen from '@v/ChoiceScreen.vue'
import LoginVendor from '@v/LoginVendor.vue'
describe('ChoiceScreen', () => {
  it('renders properly', () => {
    const wrapper = mount(ChoiceScreen)
    expect(wrapper.text()).toContain('Vendor')
  })
  it('vendor button', async () => {
    const wrapper = mount(ChoiceScreen)
    const vendorWrapper = mount(LoginVendor)
    const vendorBtn = wrapper.find('v-btn#vendor-btn')
    await vendorBtn.trigger('click')
    expect(vendorWrapper.text())
  })
})
