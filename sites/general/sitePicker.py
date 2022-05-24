import sites.blu as blu
import sites.beyondHD as beyondHD
def pickSite(site):
    if site.lower()=="beyondhd" or site.lower()=="bhd":
        return beyondHD.BeyondHD()
    if site.lower()=="blu" or site.lower()=="blutopia":
        return blu.Blu()   

        