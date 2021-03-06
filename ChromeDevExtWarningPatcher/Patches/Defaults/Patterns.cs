﻿namespace ChromeDevExtWarningPatcher.Patches.Defaults { // 0xFF is ?
    public class RemoveExtensionWarningPattern : BytePatchPattern { // ShouldIncludeExtension; "ProxyOverriddenBubble.UserSelection" 2nd next
        public RemoveExtensionWarningPattern() : base("Remove Extension Warning") {
            AlternativePatternsX64.Add(new byte[] { 0x56, 0x48, 0x83, 0xEC, 0x20, 0x48, 0x89, 0xD6, 0x48, 0x89, 0xD1, 0xE8, 0xFF, 0xFF, 0xFF, 0xFF, 0x89, 0xC1 });

            AlternativePatternsX86.Add(new byte[] { 0x55, 0x89, 0xE5, 0x56, 0x8B, 0x75, 0xFF, 0x89, 0xF1, 0xE8, 0xFF, 0xFF, 0xFF, 0xFF, 0x89, 0xC1, 0xB0, 0xFF, 0x83, 0xF9, 0xFF });
        }
    }

    public class RemoveDebugWarningPattern : BytePatchPattern { // MaybeAddInfoBar; "MaybeAddInfoBar"
        public RemoveDebugWarningPattern() : base("Remove Debug Warning") {
            AlternativePatternsX64.Add(new byte[] { 0x41, 0x57, 0x41, 0x56, 0x41, 0x54, 0x56, 0x57, 0x53, 0x48, 0x81, 0xEC, 0xFF, 0xFF, 0xFF, 0xFF, 0x49, 0x89, 0xCC, 0x48, 0x8B, 0x05, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x31, 0xE0, 0x48, 0x89, 0x84, 0x24, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x8D, 0x4A, 0xFF });
            AlternativePatternsX64.Add(new byte[] { 0x41, 0x57, 0x41, 0x56, 0x56, 0x57, 0x53, 0x48, 0x81, 0xEC, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x89, 0xCE, 0x48, 0x8B, 0x05, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x31, 0xE0, 0x48, 0x89, 0x84, 0x24, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x8D, 0x4A, 0x08 });

            AlternativePatternsX86.Add(new byte[] { 0x55, 0x89, 0xE5, 0x53, 0x57, 0x56, 0x83, 0xE4, 0xFF, 0x83, 0xEC, 0xFF, 0x89, 0xE6, 0xA1, 0xFF, 0xFF, 0xFF, 0xFF, 0x89, 0xCF, 0x8B, 0x4D, 0xFF, 0x31, 0xE8, 0x83, 0xC1, 0xFF });
        }
    }

    public class RemoveElisionPattern : BytePatchPattern { // ShouldPreventElision; "jknemblkbdhdcpllfgbfekkdciegfboi" inside or "https://support.google.com/chrome/?p=unauthenticated" 3rd next
        public RemoveElisionPattern() : base("Remove Elision") {
            AlternativePatternsX64.Add(new byte[] { 0x56, 0x57, 0x53, 0x48, 0x83, 0xEC, 0x40, 0x48, 0x8B, 0x05, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x31, 0xE0, 0x48, 0x89, 0x44, 0x24, 0xFF, 0xE8, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x85, 0xC0, 0x74, 0x61 });

            AlternativePatternsX86.Add(new byte[] { 0x55, 0x89, 0xE5, 0x53, 0x57, 0x56, 0x83, 0xEC, 0xFF, 0xA1, 0xFF, 0xFF, 0xFF, 0xFF, 0x31, 0xE8, 0x89, 0x45, 0xFF, 0xE8, 0xFF, 0xFF, 0xFF, 0xFF, 0x85, 0xC0, 0x74, 0xFF, 0x50, 0xE8, 0xFF, 0xFF, 0xFF, 0xFF, 0x83, 0xC4, 0xFF, 0x8D, 0x58, 0xFF });
        }
    }
}
