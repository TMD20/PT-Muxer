// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#pragma once

#include "pal_compiler.h"

BEGIN_EXTERN_C

#include "pal_types.h"

typedef struct UTimBuf
{
    int64_t AcTime;
    int64_t ModTime;
} UTimBuf;

typedef struct TimeValPair
{
    int64_t AcTimeSec;
    int64_t AcTimeUSec;
    int64_t ModTimeSec;
    int64_t ModTimeUSec;
} TimeValPair;

/**
 * Sets the last access and last modified time of a file
 *
 * Returns 0 on success; otherwise, returns -1 and errno is set.
 */
DLLEXPORT int32_t SystemNative_UTime(const char* path, UTimBuf* time);

/**
 * Sets the last access and last modified time of a file (with microsecond granularity)
 *
 * Returns 0 on success; otherwise, returns -1 and errno is set.
 */
DLLEXPORT int32_t SystemNative_UTimes(const char* path, TimeValPair* times);

/**
 * Gets the resolution of the timestamp, in counts per second.
 *
 * Returns 1 on success; otherwise, 0 on failure.
 */
DLLEXPORT int32_t SystemNative_GetTimestampResolution(uint64_t* resolution);

/**
 * Gets a high-resolution timestamp that can be used for time-interval measurements.
 *
 * Returns 1 on success; otherwise, 0 on failure.
 */
DLLEXPORT int32_t SystemNative_GetTimestamp(uint64_t* timestamp);

DLLEXPORT int32_t SystemNative_GetAbsoluteTime(uint64_t* timestamp);

DLLEXPORT int32_t SystemNative_GetTimebaseInfo(uint32_t* numer, uint32_t* denom);

END_EXTERN_C
