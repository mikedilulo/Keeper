<template>
  <div class="questionsstorage container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionsstorage container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1
            class="mt-5 d-flex justify-content-center mb-5"
          >STORAGE FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Will I run out of storage for keeps?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentyoneAnswer()">
              <i class="fas fa-caret-down text-warning questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyone"
              class="paragraphalign mt-4"
            >Currently there is no way to run out of storage space for your keeps. You are more than welcome to create as many keeps as you would like. If you do run into storage issues give us a call or send us an email. We will look into it promptly.</p>
          </div>
          <hr class="storagehr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Will I run out of storage for vaults?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentytwoAnswer()">
              <i class="fas fa-caret-down text-warning questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentytwo"
              class="paragraphalign mt-4"
            >Currently there is no way for you to run out of storage for your vaults. You are more than welcome to create as many vaults as possible. If you do run into storage space give us a call or send us an email. We will look into it promptly.</p>
          </div>
          <hr class="storagehr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Will I run out of storage for keeps inside vaults?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentythreeAnswer()">
              <i class="fas fa-caret-down text-warning questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentythree"
              class="paragraphalign mt-4"
            >Currently you can store as many keeps as you would like inside of vaults. If you do run into any storage issues, feel free to give us a call so we can resolve the issue.</p>
          </div>
          <hr class="storagehr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I purchase more storage?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentyfourAnswer()">
              <i class="fas fa-caret-down text-warning questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyfour"
              class="paragraphalign mt-4"
            >You do not need to purchase more storage at this time. You have an unlimited amount and there is no limit. If you do run into storage issues, feel free to give us a call or send us an email and we will look into your situation.</p>
          </div>
          <hr class="storagehr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>What if my storage runs out?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentyfiveAnswer()">
              <i class="fas fa-caret-down text-warning questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyfive"
              class="paragraphalign mt-4"
            >Feel free to call us or send us an email if you feel concerned about your storage space. We will have somebody look into it as soon as possible to get it resolved. Currently there is no need to worry about running out of space.</p>
          </div>
          <hr class="storagehr" />
        </div>
        <div class="col-md-11 mt-5 d-flex justify-content-between mb-2">
          <div class="col-md-2">
            <p>
              <strong>@Keeper2020</strong>
            </p>
          </div>
          <div class="col-md-8 d-flex justify-content-around">
            <a class="fab fa-facebook-square text-dark" href="https://www.facebook.com"></a>
            <a class="fab fa-twitter-square text-dark" href="https://www.twitter.com"></a>
            <a class="fab fa-linkedin text-dark" href="https://www.linkedin.com"></a>
            <a class="fab fa-github-square text-dark" href="https://www.github.com"></a>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import aboutnav from "@/components/AboutNavbar.vue";
export default {
  name: "questionsstorage",
  components: {
    aboutnav
  },
  methods: {
    displayTwentyoneAnswer() {
      var x = document.getElementById("divtwentyone");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentytwoAnswer() {
      var x = document.getElementById("divtwentytwo");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentythreeAnswer() {
      var x = document.getElementById("divtwentythree");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentyfourAnswer() {
      var x = document.getElementById("divtwentyfour");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentyfiveAnswer() {
      var x = document.getElementById("divtwentyfive");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    }
  }
};
</script>

<style>
.questiondrop {
  font-size: 30px;
}
.paragraphalign {
  margin-left: 5%;
}
.storagehr {
  border: 1px solid yellow;
  max-width: 80%;
  margin-right: 15%;
}
</style>