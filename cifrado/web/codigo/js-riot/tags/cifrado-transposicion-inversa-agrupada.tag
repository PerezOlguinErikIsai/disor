<cifrado-transposicion-inversa-agrupada>

  <fieldset>
  <legend>Cifrado por transposición inversa agrupada</legend>
    <label>Agrupación</label>
      <input type="number" name="desplaza">
    
    <label>Mensaje cifrado</label>
     <textarea name="comment" ref='comentario' onKeyUp={cambioComentario}></textarea>

<script>
  this.cambioComentario = function (evt) {
    let nueva_letra = String.fromCharCode(evt.charCode)
    this.comment = this.refs.comentario.value + nueva_letra
  }
</script>
    

  </fieldset>

  <article class='preview comment'>
    <p>{comment}</p>
  </article>
</cifrado-transposicion-inversa-agrupada>