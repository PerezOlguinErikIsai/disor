<preview-comment>
 

  <fieldset>
  <legend>Cifrado cesar</legend>
    <label>Desplazamiento</label>
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
</preview-comment>