// Licensed to the Rapture Project under one or more agreements.
// The Rapture Project licenses this file to you under the MIT license.

using System.Security.Cryptography;

namespace Rapture.Client.Common.Cryptography;

/// <summary>
/// Represents the abstract base class from which all implementations of Blowfish must inherit.
/// </summary>
public abstract class Blowfish : SymmetricAlgorithm
{
    private static readonly KeySizes[] s_legalBlockSizes = [new(64, 64, 0)];
    private static readonly KeySizes[] s_legalKeySizes = [new(32, 448, 8)];

    /// <summary>
    /// Initializes a new instance of the <see cref="Blowfish"/> class.
    /// </summary>
    protected Blowfish()
    {
        LegalBlockSizesValue = (KeySizes[])s_legalBlockSizes.Clone();
        LegalKeySizesValue = (KeySizes[])s_legalKeySizes.Clone();

        BlockSizeValue = 64;
        FeedbackSizeValue = 0;
        KeySizeValue = 32;
        ModeValue = CipherMode.ECB;
    }

    /// <summary>
    /// Creates a cryptographic object that is used to perform the symmetric algorithm.
    /// </summary>
    /// <returns>A cryptographic object that is used to perform the symmetric algorithm.</returns>
    public static new Blowfish Create()
    {
        return new BlowfishImplementation();
    }
}
