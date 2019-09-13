// <summary>
// AttackResult gives the result after a shot has been made.
// </summary>

public class AttackResult
{
    // <summary>
    // The result of the attack
    // </summary>
    // <value>The result of the attack</value>
    // <returns>The result of the attack</returns>
    public readonly ResultOfAttack Value { get; private set; }

    // <summary>
    // The ship, if any, involved in this result
    // </summary>
    // <value>The ship, if any, involved in this result</value>
    // <returns>The ship, if any, involved in this result</returns>

    public readonly Ship Ship { get; private set; }

    // <summary>
    // A textual description of the result.
    // </summary>
    // <value>A textual description of the result.</value>
    // <returns>A textual description of the result.</returns>
    // <remarks>A textual description of the result.</remarks>

    public readonly string Text { get; private set; }

    // <summary>
    // The row where the attack occurred
    // </summary>
    public readonly int Row { get; private set; }

    // <summary>
    // The column where the attack occurred
    // </summary>
    public readonly int Column { get; private set; }

    // <summary>
    // Set the _Value to the PossibleAttack value
    // </summary>
    // <param name="value">either hit, miss, destroyed, shotalready</param>
    public void SurroundingClass(ResultOfAttack value, string text, int row, int column)
    {
        Value = value;
        Text = text;
        Ship = null;
        Row = row;
        Column = column;
    }

    // <summary>
    // Set the _Value to the PossibleAttack value, and the _Ship to the ship
    // </summary>
    // <param name="value">either hit, miss, destroyed, shotalready</param>
    // <param name="ship">the ship information</param>
    public void SurroundingClass(ResultOfAttack value, Ship ship, string text, int row, int column) :
        this

    (value, text, row, column)
    {
        Ship = ship;
    }

    // <summary>
    // Displays the textual information about the attack
    // </summary>
    // <returns>The textual information about the attack</returns>
    public override string ToString()
    {
        if (Ship == null) return Text;
        return Text + " " + Ship.Name;
    }
}