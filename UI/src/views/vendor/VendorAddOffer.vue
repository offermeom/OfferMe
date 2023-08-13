<template>
  <v-app>
    <v-toolbar color="primary" elevation="2" dark class="toolbar-custom">
      <v-btn icon class="d-flex" @click="GoToHome()"><v-icon>mdi-chevron-left</v-icon></v-btn>
      <span class="white--text d-flex align-center mt-1"> Add product Offer </span>
    </v-toolbar>

    <div class="d-flex justify-center mt-10">
      <v-card max-widt="150" elevation="0">
        <!-- <v-img
         lazy-src="https://picsum.photos/id/11/10/6"
        max-height="150"
        max-width="150"
        src="https://picsum.photos/id/11/500/300"
        ></v-img> -->
        <input type="file" id="files" name="files[]" multiple />
      </v-card>
    </div>

    <v-container>
      <v-text-field label="Product Name" hide-details="auto" class="mb-1"></v-text-field>

      <v-row class="mb-1">
        <v-col cols="4">
          <v-text-field label="MRP" hide-details="auto"></v-text-field>
        </v-col>

        <v-col cols="4">
          <v-text-field label="Selling Price" hide-details="auto"></v-text-field>
        </v-col>

        <v-col cols="4">
          <v-text-field label="Offer Price" hide-details="auto"></v-text-field>
        </v-col>
      </v-row>

      <v-text-field label="Product Type" hide-details="auto" class="mb-1"></v-text-field>

      <v-text-field label="GSTIN" hide-details="auto" class="mb-1"></v-text-field>

      <v-row class="mb-1">
        <v-col cols="0">
          <v-menu
            ref="frommenudate"
            v-model="frommenudate"
            :close-on-content-click="false"
            v-model:return-value="fromdate"
            transition="scale-transition"
            offset-y
            min-width="290px"
          >
            <template v-slot:activator="{ on, attrs }">
              <v-text-field
                v-model="fromdate"
                label="Valid from"
                prepend-icon="mdi-calendar"
                readonly
                v-bind="attrs"
                v-on="on"
                clearable
              ></v-text-field>
            </template>
            <v-date-picker v-model="fromdate" no-title scrollable>
              <v-spacer></v-spacer>
              <v-btn text color="primary" @click="frommenudate = false">Cancel</v-btn>
              <v-btn text color="primary" @click="$refs.frommenudate.save(fromdate)">OK</v-btn>
            </v-date-picker>
          </v-menu>
        </v-col>

        <v-col cols="6">
          <v-menu
            ref="tomenudate"
            v-model="tomenudate"
            :close-on-content-click="false"
            v-model:return-value="todate"
            transition="scale-transition"
            offset-y
            min-width="290px"
          >
            <template v-slot:activator="{ on, attrs }">
              <v-text-field
                v-model="todate"
                label="Valid till"
                prepend-icon="mdi-calendar"
                readonly
                v-bind="attrs"
                v-on="on"
                clearable
              ></v-text-field>
            </template>
            <v-date-picker v-model="todate" no-title scrollable>
              <v-spacer></v-spacer>
              <v-btn text color="primary" @click="tomenudate = false">Cancel</v-btn>
              <v-btn text color="primary" @click="$refs.tomenudate.save(todate)">OK</v-btn>
            </v-date-picker>
          </v-menu>
        </v-col>
      </v-row>

      <div class="mb-1 d-flex justify-space-around">
        <v-btn depressed color="#379AFF" class="white--text" width="150px"> Create </v-btn>

        <v-btn depressed outlined color="warning" class="" width="150px" @click="GoToHome()">
          Cancel
        </v-btn>
      </div>
    </v-container>

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
      fromdate: null,
      todate: null,
      frommenudate: false,
      tomenudate: false
      // modal: false,
      // menu2: false,
    }
  },

  methods: {
    navigateToHistory() {
      this.$router.push('/registervendor')
    },
    navigateToProfile() {
      this.$router.push('/registervendor')
    },
    GoToHome() {
      this.$router.push('/vendorhomescreen')
    }
  }
}

$(document).ready(function () {
  if (window.File && window.FileList && window.FileReader) {
    $('#files').on('change', function (e) {
      var files = e.target.files,
        filesLength = files.length
      for (var i = 0; i < filesLength; i++) {
        var f = files[i]
        var fileReader = new FileReader()
        fileReader.onload = function (e) {
          var file = e.target
          $(
            '<span class="pip">' +
              '<img class="imageThumb" src="' +
              e.target.result +
              '" title="' +
              file.name +
              '"/>' +
              '<br/><span class="remove">Remove image</span>' +
              '</span>'
          ).insertAfter('#files')
          $('.remove').click(function () {
            $(this).parent('.pip').remove()
          })

          // Old code here
          /*$("<img></img>", {
            class: "imageThumb",
            src: e.target.result,
            title: file.name + " | Click to remove"
          }).insertAfter("#files").click(function(){$(this).remove();});*/
        }
        fileReader.readAsDataURL(f)
      }
      console.log(files)
    })
  } else {
    alert("Your browser doesn't support to File API")
  }
})
</script>

<style>
#app {
  padding: 0px !important;
  margin: 0px !important;
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

input[type='file'] {
  display: block;
}
.imageThumb {
  max-height: 75px;
  border: 2px solid;
  padding: 1px;
  cursor: pointer;
}
.pip {
  display: inline-block;
  margin: 10px 10px 0 0;
}
.remove {
  display: block;
  background: #444;
  border: 1px solid black;
  color: white;
  text-align: center;
  cursor: pointer;
}
.remove:hover {
  background: white;
  color: black;
}
</style>
