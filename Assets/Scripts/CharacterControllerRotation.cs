public class CharacterControllerRotation : BaseCharacterRotation
{
    private new void Update()
    {
        base.Update();
        RotateCharacter();
    }
}