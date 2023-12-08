<template>
  <v-app>
    <v-toolbar color="primary" elevation="2" dark class="toolbar-custom">
      <v-btn icon class="d-flex" @click="GoToHome()"
        ><v-icon>mdi-chevron-left</v-icon></v-btn
      >
      <span class="white--text d-flex align-center mt-1">
        View Product Offer
      </span>
    </v-toolbar>
    <div v-for="(productView, index) in productsView" :key="index">
      <div class="d-flex justify-center mt-10">
        <v-card max-width="150" elevation="0">
          <!-- <v-img
         lazy-src="https://picsum.photos/id/11/10/6"
        max-height="150"
        max-width="150"
        src="https://picsum.photos/id/11/500/300"
        ></v-img> -->
          <img
            :src="productView.image"
            :alt="productView.name"
            style="width: 150px"
          />
        </v-card>
      </div>

      <v-container>
        <p class="ma-0 grey--text text--darken-1">Product Name :</p>
        <p>{{ productView.name }}</p>

        <v-row class="mb-1">
          <v-col class="pb-0" cols="4">
            <p class="ma-0 grey--text text--darken-1">MRP :</p>
            <p>{{ productView.mrp }}</p>
          </v-col>

          <v-col class="pb-0" cols="4">
            <p class="ma-0 grey--text text--darken-1">Selling Price :</p>
            <p>{{ productView.sellingprice }}</p>
          </v-col>

          <v-col class="pb-0" cols="4">
            <p class="ma-0 grey--text text--darken-1">Offer Price :</p>
            <p>{{ productView.offerprice }}</p>
          </v-col>
        </v-row>
        <p class="ma-0 grey--text text--darken-1">Product type :</p>
        <p>{{ productView.producttype }}</p>
        <p class="ma-0 grey--text text--darken-1">GST No:</p>
        <p>{{ productView.gst }}</p>

        <v-row class="mb-1">
          <v-col cols="6">
            <p class="ma-0 grey--text text--darken-1">From Date :</p>
            <p>{{ productView.fromdate }}</p>
          </v-col>

          <v-col cols="6">
            <p class="ma-0 grey--text text--darken-1">To Date :</p>
            <p>{{ productView.todate }}</p>
          </v-col>
        </v-row>
      </v-container>
    </div>
    <div class="mb-1 d-flex justify-space-around">
      <v-btn depressed color="primary" class="white--text" width="150px">
        Edit
      </v-btn>

      <v-btn depressed outlined color="error" class="" width="150px">
        Delete
      </v-btn>
    </div>

    <v-bottom-navigation app class="d-flex justify-space-around">
      <v-btn icon>
        <v-icon @click="navigateToHome()">mdi-home</v-icon>
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

<script>
export default {
  data() {
    return {
      productsView: [
        {
          id: 1,
          name: "Nike Shoes",
          image: "https://picsum.photos/id/11/500/300",
          mrp: "500/-",
          sellingprice: "200/-",
          offerprice: "150/-",
          producttype: "shoe",
          gst: "asdf",
          fromdate: "12-12-23",
          todate: "13-01-24",
        },
      ],
    };
  },

  methods: {
    navigateToHome() {
      this.$router.push("/vendorhomescreen");
    },
    navigateToHistory() {
      this.$router.push("/registervendor");
    },
    navigateToProfile() {
      this.$router.push("/registervendor");
    },
    GoToHome() {
      this.$router.push("/vendorhomescreen");
    },
  },
};

$(document).ready(function () {
  if (window.File && window.FileList && window.FileReader) {
    $("#files").on("change", function (e) {
      var files = e.target.files,
        filesLength = files.length;
      for (var i = 0; i < filesLength; i++) {
        var f = files[i];
        var fileReader = new FileReader();
        fileReader.onload = function (e) {
          var file = e.target;
          $(
            '<span class="pip">' +
              '<img class="imageThumb" src="' +
              e.target.result +
              '" title="' +
              file.name +
              '"/>' +
              '<br/><span class="remove">Remove image</span>' +
              "</span>"
          ).insertAfter("#files");
          $(".remove").click(function () {
            $(this).parent(".pip").remove();
          });

          // Old code here
          /*$("<img></img>", {
            class: "imageThumb",
            src: e.target.result,
            title: file.name + " | Click to remove"
          }).insertAfter("#files").click(function(){$(this).remove();});*/
        };
        fileReader.readAsDataURL(f);
      }
      console.log(files);
    });
  } else {
    alert("Your browser doesn't support to File API");
  }
});
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

input[type="file"] {
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