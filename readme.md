<h1>Basic first person and third person movement in unity 3d in 89 lines of code</h1>


<p>The main goal of this project was to create basic FPS and 3rd person movement.</p>
<h6>1. Why sum with yRotation and decrease with xRotation ?</h6>
To invert the rotation.
<h6>2. Why in Update the user gets input, but in FixedUpdate he is moved?</h6>
Because Update happens more often than FixedUpdate and if you put receiving input in FixedUpdate, there is a chance of losing input from the user.
<h6>3. Why is user input normalized?</h6>
<p>Because if we do not → the player can hold multiple keys and move faster.</p>
<h6>4. Why does my character not stop moving immediately after I release the movement buttons?</h6>
<p>By default Input.GetAxis adds smoothness, to remove this effect try using Input.GetAxisRaw. 
In BaseCharacterMovement, you'll need to change the movementVector to:
movementVector = (transform.right * Input.GetAxisRaw("Horizontal") + Input.GetAxisRaw("Vertical") * transform.forward).normalized;</p>
