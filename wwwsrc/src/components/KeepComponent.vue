<template>
  <div class="keepcomponent container-fluid">
    <div class="row">
      <div class="col-md-2 mb-5 mt-5">
        <div class="latest-card">
          <div class="card-body p-0">
            <div class="dropdown">
              <button
                class="btn btn-light dropdown-toggle d-flex justify-content-end ml-1"
                type="button"
                id="dropdownMenuButton"
                data-toggle="dropdown"
                aria-haspopup="true"
                aria-expanded="false"
              ></button>
              <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                <div>
                  <button class="dropdown-item"></button>
                </div>
              </div>
            </div>
            <img :src="keepData.img" class="latest-card image" alt />
            <dd class="d-flex justify-content-between">
              <router-link :to="{name: 'publicKeepDetails', params: {id: keepData.id}}">
                <button
                  type="button"
                  class="btn btn-dark btn-sm button"
                  @click="setActivePublicKeep(keepData.id)"
                  data-dismiss="modal"
                >
                  <i class="fas fa-ellipsis-h"></i>
                </button>
              </router-link>
              <button
                type="submit"
                class="btn btn-dark btn-sm button"
                @click="deleteKeep(keepData.id)"
              >
                <i class="fas fa-trash"></i>
              </button>
            </dd>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "keepcomponent",
  props: ["keepData"],
  methods: {
    deleteKeep(id) {
      this.$store.dispatch("deletePublicKeep", id);
    },
    setActivePublicKeep(id) {
      this.$store.dispatch("getPublicKeepById", id);
    }
  }
};
</script>

<style>
.latest-card {
  border-radius: 10px;
  max-width: 100%;
  max-height: 100%;
}
.button {
  display: none;
  z-index: 1;
}
.latest-card:hover .button {
  display: block;
}
.dropdown {
  position: absolute;
}
#dropdownMenuButton {
  min-width: 90%;
  min-height: 100%;
}
.dropdown {
  display: none;
}
.latest-card:hover .dropdown {
  display: block;
}
.card-body {
  min-height: 100%;
}
.dropbtn,
.sub-dropbtn {
  background-color: transparent;
  cursor: pointer;
  border: none;
}
</style>