        /// Diff part of patch is printed verbatim, everything else (header, warnings, ...) is printed in git encoding (GitModule.SystemEncoding)
        /// Diff part of patch is printed verbatim, everything else (header, warnings, ...) is printed in git encoding (GitModule.SystemEncoding)
        public static bool IsCombinedDiff(string diff)
        {
            return !string.IsNullOrWhiteSpace(diff) &&
                                 (diff.StartsWith("diff --cc") || diff.StartsWith("diff --combined"));
        }

            }
            combinedDiff = IsCombinedDiff(input);