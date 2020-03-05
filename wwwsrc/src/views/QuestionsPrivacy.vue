<template>
  <div class="questionsprivacy container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionsprivacy container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1
            class="mt-5 d-flex justify-content-center mb-5"
          >PRIVACY FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Are my vaults stored from other Users?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayElevenAnswer()">
              <i class="fas fa-caret-down text-dark questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="diveleven"
              class="paragraphalign mt-4"
            >Yes, your vaults will not be shown to any other users who are logged in. At this time you cannot share a vault with a user, but make sure to stay up to date with the news and updates. Currently at this time your vaults will be stored away and will not be seen. This is to ensure your privacy with your vaults and what you save.</p>
          </div>
          <hr class="privacyhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Can anybody access my Private Keeps?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwelveAnswer()">
              <i class="fas fa-caret-down text-dark questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwelve"
              class="paragraphalign mt-4"
            >No, private keeps are for your eyes only. Once you create a keep and make it private you do not have access to make it public. Stay up to date with future implementation of this.</p>
          </div>
          <hr class="privacyhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Is my data safe?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayThirteenAnswer()">
              <i class="fas fa-caret-down text-dark questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divthirteen"
              class="paragraphalign mt-4"
            >With the login system, and the due dilligence from our team, you can rest assured that your data is safe and if compromise does happen we have a 24/7 hotline, and we can go in and resolve the issue. The number for our hotline is 1(777)123-4567. There will be somebody who can redirect you with your questions.</p>
          </div>
          <hr class="privacyhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How secure is the login system?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayFourteenAnswer()">
              <i class="fas fa-caret-down text-dark questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divfourteen"
              class="paragraphalign mt-4"
            >The login system is top notch and state of the art. It is the best login system up to date. Stay tuned with future implementation of logging in with social media accounts along with Google. So you can have it all stored in one place, making it more user friendly and easy for you as the user.</p>
          </div>
          <hr class="privacyhr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Can anybody else delete my vaults or keeps?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayFifteenAnswer()">
              <i class="fas fa-caret-down text-dark questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divfifteen"
              class="paragraphalign mt-4"
            >No, no other user can delete the vaults or keeps that you have created. That is the beautiful thing about this site, you will only have access to your own keeps and vaults. If you so choose to delete your own, that is fine. You can always create a new one. You will not have access to delete any other users keeps or vaults.</p>
          </div>
          <hr class="privacyhr" />
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
  name: "questionsprivacy",
  components: {
    aboutnav
  },
  methods: {
    displayElevenAnswer() {
      var x = document.getElementById("diveleven");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwelveAnswer() {
      var x = document.getElementById("divtwelve");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayThirteenAnswer() {
      var x = document.getElementById("divthirteen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayFourteenAnswer() {
      var x = document.getElementById("divfourteen");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayFifteenAnswer() {
      var x = document.getElementById("divfifteen");
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
.privacyhr {
  border: 1px solid black;
  max-width: 80%;
  margin-right: 15%;
}
</style>