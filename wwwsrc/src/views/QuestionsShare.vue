<template>
  <div class="questionsshare container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionsshare container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1 class="mt-5 d-flex justify-content-center mb-5">SHARES FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How can I share my Keeps?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displaySixteenAnswer()">
              <i class="fas fa-caret-down text-secondary questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divsixteen"
              class="paragraphalign mt-4"
            >Although in the early development stages for this application. You currently are not able to share your keeps with anybody else. This will be something that is implemented in the future. When this feature is available you should be able to type in the user's email you want to send the keep to and it will send. Continue to follow Keeper and up to date news.</p>
          </div>
          <hr class="shareshr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Can I share my vaults?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displaySeventeenAnswer()">
              <i class="fas fa-caret-down text-secondary questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divseventeen"
              class="paragraphalign mt-4"
            >No, you cannot share your vaults with another user. This is to ensure the privacy of your vaults that you create and the keeps you keep inside of them.</p>
          </div>
          <hr class="shareshr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Can I share my information?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayEighteenAnswer()">
              <i class="fas fa-caret-down text-secondary questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="diveighteen"
              class="paragraphalign mt-4"
            >Never at anytime should you share your information with anybody. Make sure that when you create an account you create a password that is lengthy and will not be stolen by other users who are wanting to manipulate your keeps or vaults.</p>
          </div>
          <hr class="shareshr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>What if I dont know the user's email?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayNineteenAnswer()">
              <i class="fas fa-caret-down text-secondary questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divnineteen"
              class="paragraphalign mt-4"
            >In future implementation of sharing, you will be able to use a username as well if you do not know the users email. Stay tuned for up to date information and when this will become a feature.</p>
          </div>
          <hr class="shareshr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How many times can I share a Keep?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentyAnswer()">
              <i class="fas fa-caret-down text-secondary questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwenty"
              class="paragraphalign mt-4"
            >You are more than welcome to share the same keep as many times as you would like. If you do decide to share a private keep, this keep will not be displayed publically. Continue to follow us for updates as to when you will be able to make a private keep public so you can share it with anybody.</p>
          </div>
          <hr class="shareshr" />
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
  name: "questionsshare",
  components: {
    aboutnav
  },
  methods: {
    displaySixteenAnswer() {
      var x = document.getElementById("divsixteen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displaySeventeenAnswer() {
      var x = document.getElementById("divseventeen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayEighteenAnswer() {
      var x = document.getElementById("diveighteen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayNineteenAnswer() {
      var x = document.getElementById("divnineteen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentyAnswer() {
      var x = document.getElementById("divtwenty");
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
.shareshr {
  border: 1px solid grey;
  max-width: 80%;
  margin-right: 15%;
}
</style>