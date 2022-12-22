from pydash import has
import difflib


def balanced_blockquotes(str):
    """
    Check if blockquotes are balanced

    Parameters
    ----------
    str : str
        text

    Returns
    -------
    True if blockquotes are balanced, False otherwise
    """
    num_blockquotes = str.count("```")
    # balanced if even number of blockquotes
    return (num_blockquotes % 2) == 0


def split_string(str, limit, sep="\n"):
    """
    Split string

    Parameters
    ----------
    str : str
        string to split

    limit : int
        string length limit

    sep : str
        separator
        default: "\n"

    Returns
    -------
    True if blockquotes are balanced, False otherwise
    """
    limit = int(limit)
    words = str.split(sep)

    if max(map(len, words)) > limit:
        # limit is too small, return original string
        return str

    res, part, others = [], words[0], words[1:]
    for word in others:
        if (len(sep) + len(word)) > (limit - len(part)):
            res.append(part)
            part = word
        else:
            part += sep + word
    if part:
        res.append(part)

    return res


def has_many(obj, base, keys):
    """
    Check if object has many keys

    Parameters
    ----------
    obj : object
        object to test

    base : str
        base key path

    keys : list
        keys to test

    Returns
    -------
    True if all keys exist, False otherwise
    """
    for key in keys:
        lookup = ""
        if base:
            lookup += base + "."
        lookup += key
        if not has(obj, lookup):
            return False
    return True


def num_to_emoji(n):
    """
    Convert number to discord emoji

    Parameters
    ----------
    n : str
        string number

    Returns
    -------
    str discord emoji if valid, False otherwise
    """
    num_emoji_map = {
        "1": ":one:",
        "2": ":two:",
        "3": ":three:",
        "4": ":four:",
        "5": ":five:",
        "6": ":six:",
        "7": ":seven:",
        "8": ":eight:",
        "9": ":nine:",
        "10": ":ten:",
    }

    n = str(n)
    if n in num_emoji_map:
        return num_emoji_map[n]
    return False


def show_diff(actual, expected):
    """
    Show difference between expected and actual result
    using discord bold format

    Parameters
    ----------
    actual : str
        actual result

    expected : str
        expected result

    Returns
    -------
    str with differences in bold
    """
    seqm = difflib.SequenceMatcher(None, actual, expected)

    output = []
    for opcode, a0, a1, b0, b1 in seqm.get_opcodes():
        if opcode == "equal":
            output.append(seqm.a[a0:a1])
        elif opcode == "insert":
            output.append("**" + seqm.b[b0:b1] + "**")
        elif opcode == "delete":
            output.append("~~" + seqm.a[a0:a1] + "~~")
        elif opcode == "replace":
            output.append("~~" + seqm.a[a0:a1] + "~~**" + seqm.b[b0:b1] + "**")
        else:
            # unexpected opcode
            continue
    return "Hint: " + "".join(output) + "\n"


def is_float(value):
    try:
        float(value)
        return True
    except ValueError:
        return False
