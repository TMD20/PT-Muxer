def ms2Str(ms):
    return hmsx2Str(*ms2hmsxRound(ms))

def str2ms(string):
    return hmsx2ms(*str2hmsx(string))

def hmsx2Str(h, m, s, x):
    return '{:02.0f}:{:02.0f}:{:02.0f}.{:03.0f}'.format(h, m, s, x)

def str2hmsx(string):
    return tuple(float(n) for n in string.replace(',', ':').replace('.', ':').split(':'))

def ms2hmsx(ms):
    x = ms % 1000
    s = (ms // 1000) % 60
    m = (ms // 60000) % 60
    h = ms // 3600000
    return h, m ,s, x

def hmsx2ms(h, m, s, x):
    return x + s * 1000 + m * 60 * 1000 + h * 3600 * 1000

def ms2hmsxRound(ms):
    return ms2hmsx(round(ms))
