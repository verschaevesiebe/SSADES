
@Code
    ViewData("Title") = "CDN"
End Code


<style>
    section.cdnclass {
     display: flex;
     flex-direction: row;
     justify-content: space-around;
     width: 100%;
     overflow: hidden;
    }

    article{
        width: 45%;


    }

    img {
    width: 100%;
}
</style>

<section class="cdnclass">

    <article><h1>Server loaded file</h1><img src="~/images/eiffel_tower_vertical.jpg" /></article>

    <article><h1>CDN loaded file</h1><img src="" /></article>

</section>

