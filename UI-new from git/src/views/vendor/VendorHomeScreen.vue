<template>
  <v-app>
    <v-toolbar color="primary" elevation="2" dark class="toolbar-custom">
      <v-avatar class="mr-3" size="40" v-if="showAvatar">
        <img
          src="https://images.unsplash.com/photo-1483909796554-bb0051ab60ad?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Z2lybCUyMHByb2ZpbGV8ZW58MHx8MHx8&w=1000&q=80"
          alt="Profile Picture"
        />
      </v-avatar>
      <span class="white--text" v-if="showUserName">
        {{ username }}
      </span>
      <v-spacer v-if="showSpcer"></v-spacer>
      <v-icon class="search-icon" v-if="showSearchIcon" @click="toggleSearch">mdi-magnify</v-icon>
      <v-icon class="close-icon mr-2" v-else @click="toggleSearch">mdi-close</v-icon>
      <v-text-field
        v-if="showSearchInput"
        clearable
        v-model="search"
        label="Search"
        single-line
        hide-details
        @click:append="clearSearch"
      ></v-text-field>
      <v-menu offset-y>
        <template v-slot:activator="{ attrs, on }">
          <v-btn v-bind="attrs" v-on="on" icon>
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn>
        </template>

        <v-list class="pa-0">
          <v-list-item link> Settings </v-list-item>
          <v-divider></v-divider>
          <v-list-item link> App Info </v-list-item>
          <v-divider></v-divider>
          <v-list-item link> App Policy </v-list-item>
        </v-list>
      </v-menu>
    </v-toolbar>
    <div class="d-flex justify-space-between my-6">
      <div class="mx-4">
        <h3>Title</h3>
      </div>
      <div class="mx-4">
        <v-btn x-small color="primary" class="white--text py-3 elevation-0">
          <!-- <v-icon class="mr-2" x-small>mdi-sort</v-icon> -->
          Sort
        </v-btn>
      </div>
    </div>

    <v-list class="pa-0">
      <v-list-item
        link
        class="pa-0"
        style="border-bottom: solid 1px #e1e1e1"
        v-for="(product, index) in products"
        :key="index"
      >
        <v-row @click="log(product)" class="list-row d-flex align-center mx-0">
          <v-col cols="2" class="d-flex justify-center">
            <v-avatar size="38">
              <img :src="product.image" :alt="product.name" />
            </v-avatar>
          </v-col>

          <v-col cols="7">
            <p class="ma-0">{{ product.name }}</p>
            <p class="ma-0 caption d-flex align-center grey--text">
              {{ product.productstatus }}
              <span class="ml-2"
                ><v-avatar :class="{ active: product.active, inactive: !product.active }" size="7">
                </v-avatar
              ></span>
            </p>
          </v-col>

          <v-col cols="3" class="o-percent d-flex justify-center">
            <!-- <v-icon
                  color="#FFB775"
                  large
                  class="show-offer-percent"
                  >
                  mdi-decagram <p>xcv</p>
                </v-icon> 
                <p>{{product.offer}}</p> -->
            <div class="offer-icon-inner">
              <v-icon color="#FF6F6F" x-large class="show-offer-percent"> mdi-decagram </v-icon>
              <div class="offer-icon-badge">{{ product.offer }}</div>
            </div>
          </v-col>
        </v-row>
      </v-list-item>
    </v-list>

    <v-btn icon id="add-product" @click="goToVendorAddOffer()">
      <v-icon color="#379AFF" large>mdi-plus-circle</v-icon>
    </v-btn>

    <v-bottom-navigation app v-model="activeNavItem" class="d-flex justify-space-around">
      <v-btn icon>
        <v-icon>mdi-home</v-icon>
      </v-btn>
      <v-btn icon @click="navigateToHistory()">
        <v-icon>mdi-ticket-confirmation</v-icon>
      </v-btn>
      <v-btn icon @click="navigateToProfile()">
        <v-icon>mdi-account</v-icon>
      </v-btn>
      <!-- <v-btn icon @click="navigateTo()">
        <v-icon>mdi-account</v-icon>
      </v-btn> -->
    </v-bottom-navigation>
  </v-app>
</template>

<script lang="ts">
export default {
  data() {
    return {
      activeNavItem: 0,
      username: 'John Doe',
      profilePictureUrl: '',
      showAvatar: true,
      showUserName: true,
      showSpcer: true,
      showSearchIcon: true,
      showSearchInput: false,
      search: '',
      menuItems: ['Option 1', 'Option 2', 'Option 3'],
      toolbarElevation: 0,
      products: [
        {
          id: 1,
          name: 'Product 1',
          productstatus: 'Active',
          image: 'https://placeimg.com/100/100/tech',
          active: true,
          offer: '10%'
        },
        {
          id: 2,
          name: 'Product 2',
          productstatus: 'Active',
          image: 'https://placeimg.com/100/100/tech',
          active: true,
          offer: '40%'
        },
        {
          id: 3,
          name: 'Product 3',
          productstatus: 'Expired',
          image: 'https://placeimg.com/100/100/tech',
          active: false,
          offer: '55%'
        }
      ]
    }
  },

  methods: {
    handleMenuItemClick(item) {
      // Handle menu item click
      return item
    },
    toggleSearch() {
      this.showSearchIcon = !this.showSearchIcon
      this.showAvatar = !this.showAvatar
      this.showUserName = !this.showUserName
      this.showSpcer = !this.showSpcer
      this.showSearchInput = !this.showSearchInput
      // Do something else when the search icon is clicked
    },
    clearSearch() {
      this.search = ''
      // Do something else when the search is cleared
    },
    navigateToHistory() {
      this.$router.push('/registervendor')
    },
    navigateToProfile() {
      this.$router.push('/registervendor')
    },
    goToVendorAddOffer() {
      this.$router.push('/vendoraddoffer')
    },
    log(product) {
      console.log(product)
    }
  }
}
</script>

<style>
#app {
  padding: 0px !important;
  margin: 0;
}

.toolbar-custom {
  position: sticky;
  width: 100%;
  top: 0;
  z-index: 1;
}

.v-toolbar {
  flex: 0;
}

.avatar {
  display: flex;
  align-items: center;
}

.avatar.hide {
  display: none;
}

.avatar {
  display: flex;
  align-items: center;
}

.avatar.hide {
  display: none;
}

.search-icon {
  display: block;
}

.search-icon.hide {
  display: none;
}

.close-icon {
  display: none;
}

.close-icon.show {
  display: block;
}

.active {
  background-color: rgb(25 212 25);
}
.inactive {
  background-color: rgb(255, 21, 21);
}

#add-product {
  bottom: 80px;
  position: absolute;
  /* margin: 0 30px 60px 0px; */
  right: 30px;
  position: fixed;
}

#add-product .mdi-plus-circle {
  border-radius: 50%;
  background: rgb(255, 255, 255);
}

.v-item-group.v-bottom-navigation .v-btn.v-btn--active {
  color: rgb(55, 154, 255);
}

.row.list-row {
  margin: auto;
}

.offer-icon-inner {
  position: relative;
}

.offer-icon-badge {
  position: absolute;
  top: 9.5px;
  color: #fff;
  font-size: 12px;
  font-weight: bold;
  padding: 3px 8px;
  border-radius: 3px;
}
</style>
