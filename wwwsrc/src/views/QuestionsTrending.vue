<template>
  <div class="questionstrending container-fluid pr-0 pl-0">
    <aboutnav />
    <div class="questionstrending container-fluid">
      <div class="row">
        <div class="col-md-12">
          <h1
            class="mt-5 d-flex justify-content-center mb-5"
          >TRENDING FREQUENTLY ASKED QUESTIONS(FAQ)</h1>
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>How do I know if my keep is trending?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentysixAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentysix"
              class="paragraphalign mt-4"
            >Currently there is no way to know if your keep is trending. In the future we will be implementing an icon letting you know that your keep is trending. You will also be notified by the email you register with when we implement that feature.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>What happens when my keep is trending?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentysevenAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyseven"
              class="paragraphalign mt-4"
            >In future implementation of a trending status, you will be notified via email and an icon will show on your keep to let you know that it is trending. You're keep if trending will show up on the "Hottest Keeps" section of this application.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Can I have more than one keep trending at a time?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentyeightAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentyeight"
              class="paragraphalign mt-4"
            >Yes with future implementation of trending keeps it will be very possible that you can have more than one keep trending. You will continue to be notified and updated if your keeps are trending. Look for them in the "Hottest Keeps" section of the application. Brag and show your friends.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Does anything happen when my keep is trending?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayTwentynineAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divtwentynine"
              class="paragraphalign mt-4"
            >There will be three things that happen when your keep is trending. You will be notified via email with the registered email, you will have an icon on your keep letting you know its trending, and you will see your keep in the "Hottest Keeps" section of the application.</p>
          </div>
          <hr class="trendinghr" />
        </div>
        <div class="col-md-12">
          <div class="d-flex justify-content-around">
            <h5 class="questionhead mt-5">
              <strong>Can I have a keep trend more than once?</strong>
            </h5>
            <button class="btn btn-none mt-5 pt-0" @click="displayThirtyAnswer()">
              <i class="fas fa-caret-down text-danger questiondrop"></i>
            </button>
          </div>
          <div class="d-flex justify-content-center col-md-10">
            <p
              id="divthirty"
              class="paragraphalign mt-4"
            >Currently there is not a way for your keeps to trend more than once. With future implementation of trending keeps, we will look to ensure that if your keep is a hot commodity, that it is trending more than once.</p>
          </div>
          <hr class="trendinghr" />
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
  name: "questionstrending",
  components: {
    aboutnav
  },
  methods: {
    displayTwentysixAnswer() {
      var x = document.getElementById("divtwentysix");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentysevenAnswer() {
      var x = document.getElementById("divtwentyseven");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentyeightAnswer() {
      var x = document.getElementById("divtwentyeight");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayTwentynineAnswer() {
      var x = document.getElementById("divtwentynine");
      if (x.style.display === "none") {
        x.style.display = "block";
      } else {
        x.style.display = "none";
      }
    },
    displayThirtyAnswer() {
      var x = document.getElementById("divthirty");
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
.trendinghr {
  border: 1px solid red;
  max-width: 80%;
  margin-right: 15%;
}
</style>