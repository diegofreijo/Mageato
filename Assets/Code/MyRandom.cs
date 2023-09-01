public static class MyRandom
{
    public static bool RandomBool(float chance)
    {
        return UnityEngine.Random.Range(0f, 1f) < chance;
    }
}
